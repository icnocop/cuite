using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Base class for all Html controls, inherits from ControlBase
    /// </summary>
    /// <typeparam name="T">The Coded UI Test Html control type</typeparam>
    public class HtmlControl<T> : ControlBase<T>, IHtmlControl where T : CUITControls.HtmlControl
    {
        public HtmlControl(T sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        /// <summary>
        /// Gets the text content of this control.
        /// </summary>
        public string InnerText
        {
            get
            {
                WaitForControlReady();
                return SourceControl.InnerText;
            }
        }

        /// <summary>
        /// Gets the value of the Help Text attribute of this control.
        /// </summary>
        public string HelpText
        {
            get
            {
                WaitForControlReady();
                return SourceControl.HelpText;
            }
        }

        /// <summary>
        /// Gets the value of the Title attribute of this control.
        /// </summary>
        public string Title
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Title;
            }
        }

        /// <summary>
        /// Gets the value of the Value attribute of this control.
        /// </summary>
        public string ValueAttribute
        {
            get
            {
                WaitForControlReady();
                return SourceControl.ValueAttribute;
            }
        }

        /// <summary>
        /// Gets the value of the AccessKey attribute of this control.
        /// </summary>
        public string AccessKey
        {
            get
            {
                WaitForControlReady();
                return SourceControl.AccessKey;
            }
        }

        /// <summary>
        /// Gets the parent of the current CUITe control.
        /// </summary>
        public override ControlBase Parent
        {
            get
            {
                WaitForControlReady();
                ControlBase ret = null;
                try
                {
                    ret = WrapUtil((CUITControls.HtmlControl)SourceControl.GetParent());
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new InvalidTraversalException(string.Format("({0}).Parent", SourceControl.GetType().Name));
                }
                return ret;
            }
        }

        /// <summary>
        /// Gets the previous sibling of the current CUITe control.
        /// </summary>
        public override ControlBase PreviousSibling
        {
            get
            {
                WaitForControlReady();
                ControlBase ret = null;
                try
                {
                    ret = WrapUtil((CUITControls.HtmlControl)SourceControl.GetParent().GetChildren()[GetMyIndexAmongSiblings() - 1]);
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new InvalidTraversalException(string.Format("({0}).PreviousSibling", SourceControl.GetType().Name));
                }
                return ret;
            }
        }

        /// <summary>
        /// Gets the next sibling of the current CUITe control.
        /// </summary>
        public override ControlBase NextSibling
        {
            get
            {
                WaitForControlReady();
                ControlBase ret = null;
                try
                {
                    UITestControl parent = SourceControl.GetParent();

                    UITestControlCollection children = parent.GetChildren();

                    int thisIndex = GetMyIndexAmongSiblings();

                    UITestControl child = children[thisIndex + 1];

                    ret = WrapUtil((CUITControls.HtmlControl)child);
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new InvalidTraversalException(string.Format("({0}).NextSibling", SourceControl.GetType().Name));
                }
                return ret;
            }
        }

        /// <summary>
        /// Gets the first child of the current CUITe control.
        /// </summary>
        public override ControlBase FirstChild
        {
            get
            {
                WaitForControlReady();
                ControlBase ret = null;
                try
                {
                    ret = WrapUtil((CUITControls.HtmlControl)SourceControl.GetChildren()[0]);
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new InvalidTraversalException(string.Format("({0}).FirstChild", SourceControl.GetType().Name));
                }
                return ret;
            }
        }

        /// <summary>
        /// Returns a list of all first level children of the current CUITe control.
        /// </summary>
        /// <returns>list of all first level children</returns>
        public override List<ControlBase> GetChildren()
        {
            WaitForControlReady();
            var uicol = new List<ControlBase>();
            foreach (UITestControl uitestcontrol in SourceControl.GetChildren())
            {
                uicol.Add(WrapUtil((CUITControls.HtmlControl)uitestcontrol));
            }
            return uicol;
        }

        private ControlBase WrapUtil(CUITControls.HtmlControl control)
        {
            ControlBase _con = null;
            if (control.GetType() == typeof(CUITControls.HtmlButton))
            {
                _con = new HtmlButton((CUITControls.HtmlButton)control);
            }
            else if (control.GetType() == typeof(CUITControls.HtmlCheckBox))
            {
                _con = new HtmlCheckBox((CUITControls.HtmlCheckBox)control);
            }
            else if (control.GetType() == typeof(CUITControls.HtmlComboBox))
            {
                _con = new HtmlComboBox((CUITControls.HtmlComboBox)control);
            }
            else if (control.GetType() == typeof(CUITControls.HtmlDiv))
            {
                _con = new HtmlDiv((CUITControls.HtmlDiv)control);
            }
            else if (control.GetType() == typeof(CUITControls.HtmlEdit) && (string.Compare(control.Type, "password", true) == 0))
            {
                _con = new HtmlPassword((CUITControls.HtmlEdit)control);
            }
            else if (control.GetType() == typeof(CUITControls.HtmlEdit))
            {
                _con = new HtmlEdit((CUITControls.HtmlEdit)control);
            }
            else if (control.GetType() == typeof(CUITControls.HtmlEditableDiv))
            {
                _con = new HtmlEditableDiv((CUITControls.HtmlEditableDiv)control);
            }
            else if (control.GetType() == typeof(CUITControls.HtmlFileInput))
            {
                _con = new HtmlFileInput((CUITControls.HtmlFileInput)control);
            }
            else if (control.GetType() == typeof(CUITControls.HtmlHyperlink))
            {
                _con = new HtmlHyperlink((CUITControls.HtmlHyperlink)control);
            }
            else if (control.GetType() == typeof(CUITControls.HtmlImage))
            {
                _con = new HtmlImage((CUITControls.HtmlImage)control);
            }
            else if (control.GetType() == typeof(CUITControls.HtmlInputButton))
            {
                _con = new HtmlInputButton((CUITControls.HtmlInputButton)control);
            }
            else if (control.GetType() == typeof(CUITControls.HtmlLabel))
            {
                _con = new HtmlLabel((CUITControls.HtmlLabel)control);
            }
            else if (control.GetType() == typeof(CUITControls.HtmlList))
            {
                _con = new HtmlList((CUITControls.HtmlList)control);
            }
            else if (control.GetType() == typeof(CUITControls.HtmlRadioButton))
            {
                _con = new HtmlRadioButton((CUITControls.HtmlRadioButton)control);
            }
            else if (control.GetType() == typeof(CUITControls.HtmlSpan))
            {
                _con = new HtmlSpan((CUITControls.HtmlSpan)control);
            }
            else if (control.GetType() == typeof(CUITControls.HtmlEditableSpan))
            {
                _con = new HtmlEditableSpan((CUITControls.HtmlEditableSpan)control);
            }
            else if (control.GetType() == typeof(CUITControls.HtmlTable))
            {
                _con = new HtmlTable((CUITControls.HtmlTable)control);
            }
            else if (control.GetType() == typeof(CUITControls.HtmlCell))
            {
                _con = new HtmlCell((CUITControls.HtmlCell)control);
            }
            else if (control.GetType() == typeof(CUITControls.HtmlTextArea))
            {
                _con = new HtmlTextArea((CUITControls.HtmlTextArea)control);
            }
            else if (control.GetType() == typeof(CUITControls.HtmlIFrame))
            {
                _con = new HtmlIFrame((CUITControls.HtmlIFrame)control);
            }
            else if (control.GetType() == typeof(CUITControls.HtmlCustom))
            {
                switch (control.TagName.ToLower())
                {
                    case "p":
                        _con = new HtmlParagraph((CUITControls.HtmlCustom)control);
                        break;
                    case "h1":
                        _con = new HtmlHeading1((CUITControls.HtmlCustom)control);
                        break;
                    case "h2":
                        _con = new HtmlHeading2((CUITControls.HtmlCustom)control);
                        break;
                    case "h3":
                        _con = new HtmlHeading3((CUITControls.HtmlCustom)control);
                        break;
                    case "h4":
                        _con = new HtmlHeading4((CUITControls.HtmlCustom)control);
                        break;
                    case "h5":
                        _con = new HtmlHeading5((CUITControls.HtmlCustom)control);
                        break;
                    case "h6":
                        _con = new HtmlHeading6((CUITControls.HtmlCustom)control);
                        break;
                    case "ul":
                        _con = new HtmlUnorderedList((CUITControls.HtmlCustom)control);
                        break;
                    case "ol":
                        _con = new HtmlOrderedList((CUITControls.HtmlCustom)control);
                        break;
                    case "li":
                        _con = new HtmlListItem((CUITControls.HtmlCustom)control);
                        break;
                    case "ins":
                        _con = new HtmlIns((CUITControls.HtmlCustom)control);
                        break;
                    default:
                        _con = new HtmlCustom(control.TagName, (CUITControls.HtmlCustom)control);
                        break;
                }
            }
            else
            {
                throw new Exception(string.Format("WrapUtil: '{0}' not supported", control.GetType().Name));
            }
            
            return _con;
        }

        private int GetMyIndexAmongSiblings()
        {
            int i = -1;
            foreach (UITestControl uitestcontrol in SourceControl.GetParent().GetChildren())
            {
                i++;
                if (uitestcontrol == SourceControl)
                {
                    break;
                }
            }
            return i;
        }
    }
}
