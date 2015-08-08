using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Xml;
using CUITe.Exceptions;

namespace CUITe
{
    /// <summary>
    /// Data Manager
    /// </summary>
    public class CUITe_DataManager
    {
        private static XmlTextReader GetXmlTextReader(Assembly assembly, Type type, string fileName)
        {
            Stream stream = assembly.GetManifestResourceStream(type, fileName);
            if (stream == null)
            {
                throw new ResourceNotFoundException(assembly.FullName, type.ToString(), fileName);
            }

            return new XmlTextReader(stream);
        }

        private static Hashtable GetDataRow(Assembly assembly, Type type, string fileName, string dataRowId, Hashtable ht)
        {
            XmlTextReader xmlTextReader = GetXmlTextReader(assembly, type, fileName);
            bool startParsing = false;
            string key = string.Empty;
            string inherits = string.Empty;
            bool keyAdded2Ht = false;
            while (xmlTextReader.Read())
            {
                if (xmlTextReader.NodeType != XmlNodeType.Whitespace)
                {
                    if (xmlTextReader.IsStartElement() && xmlTextReader.Name.ToLower() == "datarow" && xmlTextReader.GetAttribute("id") == dataRowId)
                    {
                        if (xmlTextReader.GetAttribute("inherits") != null)
                        {
                            inherits = xmlTextReader.GetAttribute("inherits");
                        }

                        startParsing = true;
                    }

                    if (startParsing == true && xmlTextReader.NodeType == XmlNodeType.EndElement && xmlTextReader.Name.ToLower() == "datarow")
                    {
                        startParsing = false;
                        break;
                    }

                    if (startParsing == true && xmlTextReader.Name.ToLower() != "datarow")
                    {
                        if (xmlTextReader.IsStartElement())
                        {
                            key = xmlTextReader.Name.ToLower();
                            if (!ht.Contains(key))
                            {
                                keyAdded2Ht = true;
                                ht.Add(key, null);
                            }
                        }
                        
                        if (keyAdded2Ht == true && xmlTextReader.NodeType == XmlNodeType.Text)
                        {
                            keyAdded2Ht = false;
                            ht[key] = xmlTextReader.Value;
                        }

                        if (xmlTextReader.NodeType == XmlNodeType.EndElement)
                        {
                            key = string.Empty;
                        }
                    }
                }
            }

            xmlTextReader.Close();
            
            if (inherits.Length > 0)
            {
                ht = GetDataRow(assembly, type, fileName, inherits, ht);
            }

            return ht;
        }

        /// <summary>
        /// Gets the data row.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="dataRowId">The data row id.</param>
        /// <returns></returns>
        public static Hashtable GetDataRow(Type type, string fileName, string dataRowId)
        {
            Assembly assembly = Assembly.GetCallingAssembly();
            return GetDataRow(assembly, type, fileName, dataRowId, new Hashtable());
        }
    }
}
