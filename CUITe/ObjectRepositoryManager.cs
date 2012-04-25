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
using CUITe.Controls.TelerikControls;
using CUITe.Controls;

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

                if (sNodeName.StartsWith("HtmlControls.CUITe_Html"))
                {
                    switch (sNodeName)
                    {
                        case "HtmlControls.CUITe_HtmlHyperlink":
                            {
                                CUITe_HtmlHyperlink field = (CUITe_HtmlHyperlink)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlHyperlink(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlDiv":
                            {
                                CUITe_HtmlDiv field = (CUITe_HtmlDiv)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlDiv(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlCell":
                            {
                                CUITe_HtmlCell field = (CUITe_HtmlCell)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlCell(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlInputButton":
                            {
                                CUITe_HtmlInputButton field = (CUITe_HtmlInputButton)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlInputButton(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlComboBox":
                            {
                                CUITe_HtmlComboBox field = (CUITe_HtmlComboBox)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlComboBox(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlTextArea":
                            {
                                CUITe_HtmlTextArea field = (CUITe_HtmlTextArea)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlTextArea(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlTable":
                            {
                                CUITe_HtmlTable field = (CUITe_HtmlTable)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlTable(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlCheckBox":
                            {
                                CUITe_HtmlCheckBox field = (CUITe_HtmlCheckBox)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlCheckBox(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlRadioButton":
                            {
                                CUITe_HtmlRadioButton field = (CUITe_HtmlRadioButton)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlRadioButton(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlButton":
                            {
                                CUITe_HtmlButton field = (CUITe_HtmlButton)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlButton(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlEdit":
                            {
                                CUITe_HtmlEdit field = (CUITe_HtmlEdit)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlEdit(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlPassword":
                            {
                                CUITe_HtmlPassword field = (CUITe_HtmlPassword)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlEdit(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlList":
                            {
                                CUITe_HtmlList field = (CUITe_HtmlList)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlList(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlParagraph":
                            {
                                CUITe_HtmlParagraph field = (CUITe_HtmlParagraph)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlCustom(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlFileInput":
                            {
                                CUITe_HtmlFileInput field = (CUITe_HtmlFileInput)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlFileInput(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlLabel":
                            {
                                CUITe_HtmlLabel field = (CUITe_HtmlLabel)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlLabel(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlImage":
                            {
                                CUITe_HtmlImage field = (CUITe_HtmlImage)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlImage(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlSpan":
                            {
                                CUITe_HtmlSpan field = (CUITe_HtmlSpan)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlSpan(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlHeading1":
                            {
                                CUITe_HtmlHeading1 field = (CUITe_HtmlHeading1)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlCustom(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlHeading2":
                            {
                                CUITe_HtmlHeading2 field = (CUITe_HtmlHeading2)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlCustom(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlHeading3":
                            {
                                CUITe_HtmlHeading3 field = (CUITe_HtmlHeading3)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlCustom(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlHeading4":
                            {
                                CUITe_HtmlHeading4 field = (CUITe_HtmlHeading4)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlCustom(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlHeading5":
                            {
                                CUITe_HtmlHeading5 field = (CUITe_HtmlHeading5)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlCustom(browserWindow));
                            }
                            break;
                        case "HtmlControls.CUITe_HtmlHeading6":
                            {
                                CUITe_HtmlHeading6 field = (CUITe_HtmlHeading6)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new HtmlCustom(browserWindow));
                            }
                            break;
                        default:
                            throw new Exception(string.Format("ObjectRepositoryManager: '{0}' not supported", sNodeName));
                    }
                }

                #endregion

                # region SilverlightControls

                else if (sNodeName.StartsWith("SilverlightControls.CUITe_Sl"))
                {
                    switch (sNodeName)
                    {
                        case "SilverlightControls.CUITe_SlButton":
                            {
                                CUITe_SlButton field = (CUITe_SlButton)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new SilverlightButton(browserWindow.SlObjectContainer));
                            }
                            break;
                        case "SilverlightControls.CUITe_SlCalendar":
                            {
                                CUITe_SlCalendar field = (CUITe_SlCalendar)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new SilverlightCalendar(browserWindow.SlObjectContainer));
                            }
                            break;
                        case "SilverlightControls.CUITe_SlCell":
                            {
                                CUITe_SlCell field = (CUITe_SlCell)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new SilverlightCell(browserWindow.SlObjectContainer));
                            }
                            break;
                        case "SilverlightControls.CUITe_SlCheckBox":
                            {
                                CUITe_SlCheckBox field = (CUITe_SlCheckBox)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new SilverlightCheckBox(browserWindow.SlObjectContainer));
                            }
                            break;
                        case "SilverlightControls.CUITe_SlComboBox":
                            {
                                CUITe_SlComboBox field = (CUITe_SlComboBox)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new SilverlightComboBox(browserWindow.SlObjectContainer));
                            }
                            break;
                        case "SilverlightControls.CUITe_SlDataPager":
                            {
                                CUITe_SlDataPager field = (CUITe_SlDataPager)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new SilverlightDataPager(browserWindow.SlObjectContainer));
                            }
                            break;
                        case "SilverlightControls.CUITe_SlDatePicker":
                            {
                                CUITe_SlDatePicker field = (CUITe_SlDatePicker)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new SilverlightDatePicker(browserWindow.SlObjectContainer));
                            }
                            break;
                        case "SilverlightControls.CUITe_SlEdit":
                            {
                                CUITe_SlEdit field = (CUITe_SlEdit)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new SilverlightEdit(browserWindow.SlObjectContainer));
                            }
                            break;
                        case "SilverlightControls.CUITe_SlHyperlink":
                            {
                                CUITe_SlHyperlink field = (CUITe_SlHyperlink)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new SilverlightHyperlink(browserWindow.SlObjectContainer));
                            }
                            break;
                        case "SilverlightControls.CUITe_SlImage":
                            {
                                CUITe_SlImage field = (CUITe_SlImage)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new SilverlightImage(browserWindow.SlObjectContainer));
                            }
                            break;
                        case "SilverlightControls.CUITe_SlLabel":
                            {
                                CUITe_SlLabel field = (CUITe_SlLabel)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new SilverlightLabel(browserWindow.SlObjectContainer));
                            }
                            break;
                        case "SilverlightControls.CUITe_SlList":
                            {
                                CUITe_SlList field = (CUITe_SlList)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new SilverlightList(browserWindow.SlObjectContainer));
                            }
                            break;
                        case "SilverlightControls.CUITe_SlRadioButton":
                            {
                                CUITe_SlRadioButton field = (CUITe_SlRadioButton)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new SilverlightRadioButton(browserWindow.SlObjectContainer));
                            }
                            break;
                        case "SilverlightControls.CUITe_SlSlider":
                            {
                                CUITe_SlSlider field = (CUITe_SlSlider)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new SilverlightSlider(browserWindow.SlObjectContainer));
                            }
                            break;
                        case "SilverlightControls.CUITe_SlTab":
                            {
                                CUITe_SlTab field = (CUITe_SlTab)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new SilverlightTab(browserWindow.SlObjectContainer));
                            }
                            break;
                        case "SilverlightControls.CUITe_SlTabItem":
                            {
                                CUITe_SlTabItem field = (CUITe_SlTabItem)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new SilverlightTabItem(browserWindow.SlObjectContainer));
                            }
                            break;
                        case "SilverlightControls.CUITe_SlTable":
                            {
                                CUITe_SlTable field = (CUITe_SlTable)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new SilverlightTable(browserWindow.SlObjectContainer));
                            }
                            break;
                        case "SilverlightControls.CUITe_SlText":
                            {
                                CUITe_SlText field = (CUITe_SlText)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new SilverlightText(browserWindow.SlObjectContainer));
                            }
                            break;
                        case "SilverlightControls.CUITe_SlTree":
                            {
                                CUITe_SlTree field = (CUITe_SlTree)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new SilverlightTree(browserWindow.SlObjectContainer));
                            }
                            break;
                        default:
                            if (sNodeName.StartsWith("SilverlightControls.CUITe_SlControl"))
                            {
                                ICUITe_ControlBase field = (ICUITe_ControlBase)fieldinfo.GetValue(browserWindow);
                                field.Wrap(new SilverlightControl(browserWindow.SlObjectContainer));
                                break;
                            }
                            else
                            {
                                throw new Exception(string.Format("ObjectRepositoryManager: '{0}' not supported", sNodeName));
                            }
                    }
                }

                #endregion

                # region TelerikControls

                else if (sNodeName == "TelerikControls.Telerik_ComboBox")
                {
                    Telerik_ComboBox field = (Telerik_ComboBox)fieldinfo.GetValue(browserWindow);
                    field.SetWindow(browserWindow);
                }

                #endregion
            }
            return browserWindow;
        }
    }
}