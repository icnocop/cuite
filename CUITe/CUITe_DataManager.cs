using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Windows.Forms;
using System.Collections;

namespace CUITe
{
    public class CUITe_DataManager
    {
        private static XmlTextReader GetXmlTextReader(Assembly _assembly, Type type, string sFileName)
        {
            return new XmlTextReader(_assembly.GetManifestResourceStream(type, sFileName));
        }

        private static Hashtable GetDataRow(Assembly _assembly, Type type, string sFileName, string sDataRowId, Hashtable ht)
        {
            XmlTextReader _xmlTextReader = GetXmlTextReader(_assembly, type, sFileName);
            bool bStartParsing = false;
            string sKey = string.Empty;
            string sInherits = string.Empty;
            bool bKeyAdded2Ht = false;
            while (_xmlTextReader.Read())
            {
                if (_xmlTextReader.NodeType != XmlNodeType.Whitespace)
                {
                    if (_xmlTextReader.IsStartElement() && _xmlTextReader.Name.ToLower() == "datarow" && _xmlTextReader.GetAttribute("id") == sDataRowId)
                    {
                        if (_xmlTextReader.GetAttribute("inherits") != null)
                        {
                            sInherits = _xmlTextReader.GetAttribute("inherits");
                        }
                        bStartParsing = true;
                    }

                    if (bStartParsing == true && _xmlTextReader.NodeType == XmlNodeType.EndElement && _xmlTextReader.Name.ToLower() == "datarow")
                    {
                        bStartParsing = false;
                        break;
                    }

                    if (bStartParsing == true && _xmlTextReader.Name.ToLower() != "datarow")
                    {
                        if (_xmlTextReader.IsStartElement())
                        {
                            sKey = _xmlTextReader.Name.ToLower();
                            if (!ht.Contains(sKey))
                            {
                                bKeyAdded2Ht = true;
                                ht.Add(sKey, null);
                            }
                        }
                        if (bKeyAdded2Ht == true && _xmlTextReader.NodeType == XmlNodeType.Text)
                        {
                            bKeyAdded2Ht = false;
                            ht[sKey] = _xmlTextReader.Value;
                        }
                        if (_xmlTextReader.NodeType == XmlNodeType.EndElement)
                        {
                            sKey = string.Empty;
                        }
                    }
                }
            }
            _xmlTextReader.Close();
            if (sInherits.Length > 0)
            {
                ht = GetDataRow(_assembly, type, sFileName, sInherits, ht);
            }
            return ht;
        }

        public static Hashtable GetDataRow(Type type, string sFileName, string sDataRowId)
        {
            Assembly _assembly = Assembly.GetCallingAssembly();
            return GetDataRow(_assembly, type, sFileName, sDataRowId, new Hashtable());
        }
    }
}
