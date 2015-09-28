using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Xml;

namespace CUITe.DataSources
{
    /// <summary>
    /// Class capable of loading test data from a XML file.
    /// </summary>
    public static class XmlDataSource
    {
        private const string DataBlock = "datablock";
        private const string Id = "id";
        private const string Inherits = "inherits";

        /// <summary>
        /// Gets the test data block with id <paramref name="id"/> in
        /// <paramref name="fileName"/> with namespace scoped from <paramref name="type"/>.
        /// </summary>
        /// <param name="type">
        /// The type whose namespace is used to scope the XML data source file name.
        /// </param>
        /// <param name="fileName">The case-sensitive name of the XML data source.</param>
        /// <param name="id">The id of the data block in the XML data source.</param>
        /// <returns><see cref="Hashtable"/> with data source keys and values.</returns>
        /// <exception cref="XmlDataSourceNotFoundException">
        /// Data source file name was not found.
        /// </exception>
        /// <exception cref="DataBlockIdNotFoundException">
        /// Data block id was not found in data source.
        /// </exception>
        public static Hashtable GetDataBlock(Type type, string fileName, string id)
        {
            if (type == null)
                throw new ArgumentNullException("type");
            if (fileName == null)
                throw new ArgumentNullException("fileName");
            if (id == null)
                throw new ArgumentNullException("id");

            Assembly dataSourceAssembly = Assembly.GetCallingAssembly();
            return GetDataBlock(dataSourceAssembly, type, fileName, id);
        }

        private static Hashtable GetDataBlock(Assembly dataSourceAssembly, Type type, string fileName, string id)
        {
            using (XmlTextReader dataSourceReader = GetDataSourceReader(dataSourceAssembly, type, fileName))
            {
                var data = new Hashtable(StringComparer.InvariantCultureIgnoreCase);

                bool startParsing = false;
                bool wasIdFound = false;
                string key = string.Empty;
                string inherits = null;
                bool isKeyAdded = false;

                while (dataSourceReader.Read())
                {
                    if (dataSourceReader.NodeType == XmlNodeType.Whitespace)
                        continue;
                    
                    if (dataSourceReader.IsStartElement() &&
                        IsDataBlock(dataSourceReader.Name) &&
                        dataSourceReader.GetAttribute(Id) == id)
                    {
                        if (dataSourceReader.GetAttribute(Inherits) != null)
                        {
                            inherits = dataSourceReader.GetAttribute(Inherits);
                        }

                        startParsing = true;
                        wasIdFound = true;
                    }

                    if (startParsing &&
                        dataSourceReader.NodeType == XmlNodeType.EndElement &&
                        IsDataBlock(dataSourceReader.Name))
                    {
                        break;
                    }

                    if (startParsing && !IsDataBlock(dataSourceReader.Name))
                    {
                        if (dataSourceReader.IsStartElement())
                        {
                            key = dataSourceReader.Name;
                            if (!data.Contains(key))
                            {
                                isKeyAdded = true;
                                data.Add(key, null);
                            }
                        }

                        if (isKeyAdded && dataSourceReader.NodeType == XmlNodeType.Text)
                        {
                            isKeyAdded = false;
                            data[key] = dataSourceReader.Value;
                        }

                        if (dataSourceReader.NodeType == XmlNodeType.EndElement)
                        {
                            key = string.Empty;
                        }
                    }
                }

                if (!wasIdFound)
                {
                    throw new DataBlockIdNotFoundException(id);
                }
                
                if (inherits != null)
                {
                    Hashtable inheritedData = GetDataBlock(dataSourceAssembly, type, fileName, inherits);
                    foreach (DictionaryEntry inheritedDataBlock in inheritedData)
                    {
                        data[inheritedDataBlock.Key] = inheritedDataBlock.Value;
                    }
                }

                return data;
            }
        }

        private static XmlTextReader GetDataSourceReader(Assembly assembly, Type type, string fileName)
        {
            Stream stream = assembly.GetManifestResourceStream(type, fileName);
            if (stream == null)
            {
                throw new XmlDataSourceNotFoundException(assembly, type, fileName);
            }

            return new XmlTextReader(stream);
        }

        private static bool IsDataBlock(string elementName)
        {
            return string.Compare(elementName, DataBlock, StringComparison.OrdinalIgnoreCase) == 0;
        }
    }
}