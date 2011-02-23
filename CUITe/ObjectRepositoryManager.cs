using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using CUITe.Controls.HtmlControls;
using CUITe.Controls.SilverlightControls;

namespace CUITe
{
    public class ObjectRepositoryManager
    {
        public static T GetInstance<T>()
        {
            return (T)(object)GetInstance(typeof(T));
        }

        private static CUITe_BrowserWindow GetInstance(Type typePageDefinition)
        {
            CUITe_BrowserWindow browserWindow = (CUITe_BrowserWindow)Activator.CreateInstance(typePageDefinition);
            browserWindow.SetWidowTitle(typePageDefinition.GetField("sWindowTitle").GetValue(browserWindow).ToString());

            FieldInfo[] finfo = browserWindow.GetType().GetFields();
            foreach (FieldInfo fieldinfo in finfo) 
            {
                string sNodeName = fieldinfo.FieldType.FullName.Replace("CUITe.Controls.", "");

                #region HtmlControls

                if (sNodeName == "HtmlControls.CUITe_HtmlHyperlink")
                {
                    CUITe_HtmlHyperlink field = (CUITe_HtmlHyperlink)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new HtmlHyperlink(browserWindow));
                }
                if (sNodeName == "HtmlControls.CUITe_HtmlDiv")
                {
                    CUITe_HtmlDiv field = (CUITe_HtmlDiv)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new HtmlDiv(browserWindow));
                }
                if (sNodeName == "HtmlControls.CUITe_HtmlCell")
                {
                    CUITe_HtmlCell field = (CUITe_HtmlCell)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new HtmlCell(browserWindow));
                }
                if (sNodeName == "HtmlControls.CUITe_HtmlInputButton")
                {
                    CUITe_HtmlInputButton field = (CUITe_HtmlInputButton)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new HtmlInputButton(browserWindow));
                }
                if (sNodeName == "HtmlControls.CUITe_HtmlComboBox")
                {
                    CUITe_HtmlComboBox field = (CUITe_HtmlComboBox)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new HtmlComboBox(browserWindow));
                }
                if (sNodeName == "HtmlControls.CUITe_HtmlTextArea")
                {
                    CUITe_HtmlTextArea field = (CUITe_HtmlTextArea)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new HtmlTextArea(browserWindow));
                }
                if (sNodeName == "HtmlControls.CUITe_HtmlTable")
                {
                    CUITe_HtmlTable field = (CUITe_HtmlTable)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new HtmlTable(browserWindow));
                }
                if (sNodeName == "HtmlControls.CUITe_HtmlCheckBox")
                {
                    CUITe_HtmlCheckBox field = (CUITe_HtmlCheckBox)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new HtmlCheckBox(browserWindow));
                }
                if (sNodeName == "HtmlControls.CUITe_HtmlRadioButton")
                {
                    CUITe_HtmlRadioButton field = (CUITe_HtmlRadioButton)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new HtmlRadioButton(browserWindow));
                }
                if (sNodeName == "HtmlControls.CUITe_HtmlButton")
                {
                    CUITe_HtmlButton field = (CUITe_HtmlButton)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new HtmlButton(browserWindow));
                }
                if (sNodeName == "HtmlControls.CUITe_HtmlEdit")
                {
                    CUITe_HtmlEdit field = (CUITe_HtmlEdit)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new HtmlEdit(browserWindow));
                }
                if (sNodeName == "HtmlControls.CUITe_HtmlPassword")
                {
                    CUITe_HtmlPassword field = (CUITe_HtmlPassword)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new HtmlEdit(browserWindow));
                }
                if (sNodeName == "HtmlControls.CUITe_HtmlList")
                {
                    CUITe_HtmlList field = (CUITe_HtmlList)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new HtmlList(browserWindow));
                }
                if (sNodeName == "HtmlControls.CUITe_HtmlFileInput")
                {
                    CUITe_HtmlFileInput field = (CUITe_HtmlFileInput)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new HtmlFileInput(browserWindow));
                }
                if (sNodeName == "HtmlControls.CUITe_HtmlLabel")
                {
                    CUITe_HtmlLabel field = (CUITe_HtmlLabel)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new HtmlLabel(browserWindow));
                }
                if (sNodeName == "HtmlControls.CUITe_HtmlImage")
                {
                    CUITe_HtmlImage field = (CUITe_HtmlImage)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new HtmlImage(browserWindow));
                }
                if (sNodeName == "HtmlControls.CUITe_HtmlSpan")
                {
                    CUITe_HtmlSpan field = (CUITe_HtmlSpan)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new HtmlSpan(browserWindow));
                }

                #endregion

                # region SilverlightControls

                if (sNodeName == "SilverlightControls.CUITe_SlButton")
                {
                    CUITe_SlButton field = (CUITe_SlButton)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new SilverlightButton(browserWindow.SlObjectContainer));
                }
                if (sNodeName == "SilverlightControls.CUITe_SlCheckBox")
                {
                    CUITe_SlCheckBox field = (CUITe_SlCheckBox)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new SilverlightCheckBox(browserWindow.SlObjectContainer));
                }
                if (sNodeName == "SilverlightControls.CUITe_SlComboBox")
                {
                    CUITe_SlComboBox field = (CUITe_SlComboBox)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new SilverlightComboBox(browserWindow.SlObjectContainer));
                }
                if (sNodeName == "SilverlightControls.CUITe_SlEdit")
                {
                    CUITe_SlEdit field = (CUITe_SlEdit)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new SilverlightEdit(browserWindow.SlObjectContainer));
                }
                if (sNodeName == "SilverlightControls.CUITe_SlHyperlink")
                {
                    CUITe_SlHyperlink field = (CUITe_SlHyperlink)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new SilverlightHyperlink(browserWindow.SlObjectContainer));
                }
                if (sNodeName == "SilverlightControls.CUITe_SlTabItem")
                {
                    CUITe_SlTabItem field = (CUITe_SlTabItem)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new SilverlightTabItem(browserWindow.SlObjectContainer));
                }
                if (sNodeName == "SilverlightControls.CUITe_SlTable")
                {
                    CUITe_SlTable field = (CUITe_SlTable)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new SilverlightTable(browserWindow.SlObjectContainer));
                }
                if (sNodeName == "SilverlightControls.CUITe_SlText")
                {
                    CUITe_SlText field = (CUITe_SlText)fieldinfo.GetValue(browserWindow);
                    field.Wrap(new SilverlightText(browserWindow.SlObjectContainer));
                }

                #endregion
            }
            return browserWindow;
        }
    }
}