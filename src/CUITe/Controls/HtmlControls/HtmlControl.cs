using System;
using System.Collections.Generic;
using System.Linq;
using CUITe.Browsers;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Base class for all test controls in the user interface (UI) of a Web page.
    /// </summary>
    /// <typeparam name="T">The source control type.</typeparam>
    public class HtmlControl<T> : ControlBase<T>, IHasInnerText where T : CUITControls.HtmlControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlControl{T}"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlControl(T sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the text content of this control.
        /// </summary>
        public string InnerText
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.InnerText;
            }
        }

        /// <summary>
        /// Gets the value of the HelpText attribute of this control.
        /// </summary>
        public string HelpText
        {
            get
            {
                WaitForControlReadyIfNecessary();
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
                WaitForControlReadyIfNecessary();
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
                WaitForControlReadyIfNecessary();
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
                WaitForControlReadyIfNecessary();
                return SourceControl.AccessKey;
            }
        }

        /// <summary>
        /// Gets the parent of the control.
        /// </summary>
        /// <exception cref="InvalidTraversalException">
        /// Error occurred when traversing the control tree.
        /// </exception>
        public override ControlBase Parent
        {
            get
            {
                WaitForControlReadyIfNecessary();

                try
                {
                    return WrapUtil((CUITControls.HtmlControl)SourceControl.GetParent());
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new InvalidTraversalException(string.Format("({0}).Parent", SourceControl.GetType().Name));
                }
            }
        }

        /// <summary>
        /// Gets the previous sibling of the control.
        /// </summary>
        /// <exception cref="InvalidTraversalException">
        /// Error occurred when traversing the control tree.
        /// </exception>
        public override ControlBase PreviousSibling
        {
            get
            {
                WaitForControlReadyIfNecessary();

                try
                {
                    return WrapUtil((CUITControls.HtmlControl)SourceControl.GetParent().GetChildren()[GetMyIndexAmongSiblings() - 1]);
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new InvalidTraversalException(string.Format("({0}).PreviousSibling", SourceControl.GetType().Name));
                }
            }
        }

        /// <summary>
        /// Gets the next sibling of the control.
        /// </summary>
        /// <exception cref="InvalidTraversalException">
        /// Error occurred when traversing the control tree.
        /// </exception>
        public override ControlBase NextSibling
        {
            get
            {
                WaitForControlReadyIfNecessary();

                try
                {
                    UITestControl parent = SourceControl.GetParent();

                    UITestControlCollection children = parent.GetChildren();

                    int thisIndex = GetMyIndexAmongSiblings();

                    UITestControl child = children[thisIndex + 1];

                    return WrapUtil((CUITControls.HtmlControl)child);
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new InvalidTraversalException(string.Format("({0}).NextSibling", SourceControl.GetType().Name));
                }
            }
        }

        /// <summary>
        /// Gets the first child of the control.
        /// </summary>
        /// <exception cref="InvalidTraversalException">
        /// Error occurred when traversing the control tree.
        /// </exception>
        public override ControlBase FirstChild
        {
            get
            {
                WaitForControlReadyIfNecessary();

                try
                {
                    return WrapUtil((CUITControls.HtmlControl)SourceControl.GetChildren()[0]);
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new InvalidTraversalException(string.Format("({0}).FirstChild", SourceControl.GetType().Name));
                }
            }
        }

        /// <summary>
        /// Returns a sequence of all first level children of the control.
        /// </summary>
        public override IEnumerable<ControlBase> GetChildren()
        {
            WaitForControlReadyIfNecessary();

            ControlBase[] children = SourceControl.GetChildren()
                .Select(child => WrapUtil((CUITControls.HtmlControl)child))
                .ToArray();

            Dictionary<Type, int> tagInstancesByType = new Dictionary<Type, int>();

            foreach (ControlBase child in children)
            {
                if (child.SourceControl.SearchProperties.Any())
                {
                    int tagInstances;
                    if (tagInstancesByType.ContainsKey(child.GetType()))
                    {
                        tagInstances = tagInstancesByType[child.GetType()] += 1;
                    }
                    else
                    {
                        tagInstances = tagInstancesByType[child.GetType()] = 1;
                    }

                    child.SourceControl.FilterProperties.Add(
                        CUITControls.HtmlControl.PropertyNames.TagInstance,
                        tagInstances.ToString());    
                }

                yield return child;
            }
        }

        /// <summary>
        /// Run/evaluate JavaScript code in the DOM context.
        /// </summary>
        /// <param name="code">The JavaScript code.</param>
        protected void RunScript(string code)
        {
            var browserWindow = (BrowserWindow)SourceControl.TopParent;
            InternetExplorer.RunScript(browserWindow, code);
        }

        private static ControlBase WrapUtil(CUITControls.HtmlControl sourceControl)
        {
            ControlBase control;

            if (sourceControl.GetType() == typeof(CUITControls.HtmlButton))
            {
                control = new HtmlButton((CUITControls.HtmlButton)sourceControl);
            }
            else if (sourceControl.GetType() == typeof(CUITControls.HtmlCheckBox))
            {
                control = new HtmlCheckBox((CUITControls.HtmlCheckBox)sourceControl);
            }
            else if (sourceControl.GetType() == typeof(CUITControls.HtmlComboBox))
            {
                control = new HtmlComboBox((CUITControls.HtmlComboBox)sourceControl);
            }
            else if (sourceControl.GetType() == typeof(CUITControls.HtmlDiv))
            {
                control = new HtmlDiv((CUITControls.HtmlDiv)sourceControl);
            }
            else if (sourceControl.GetType() == typeof(CUITControls.HtmlEdit) && (string.Compare(sourceControl.Type, "password", true) == 0))
            {
                control = new HtmlPassword((CUITControls.HtmlEdit)sourceControl);
            }
            else if (sourceControl.GetType() == typeof(CUITControls.HtmlEdit))
            {
                control = new HtmlEdit((CUITControls.HtmlEdit)sourceControl);
            }
            else if (sourceControl.GetType() == typeof(CUITControls.HtmlEditableDiv))
            {
                control = new HtmlEditableDiv((CUITControls.HtmlEditableDiv)sourceControl);
            }
            else if (sourceControl.GetType() == typeof(CUITControls.HtmlFileInput))
            {
                control = new HtmlFileInput((CUITControls.HtmlFileInput)sourceControl);
            }
            else if (sourceControl.GetType() == typeof(CUITControls.HtmlHyperlink))
            {
                control = new HtmlHyperlink((CUITControls.HtmlHyperlink)sourceControl);
            }
            else if (sourceControl.GetType() == typeof(CUITControls.HtmlImage))
            {
                control = new HtmlImage((CUITControls.HtmlImage)sourceControl);
            }
            else if (sourceControl.GetType() == typeof(CUITControls.HtmlInputButton))
            {
                control = new HtmlInputButton((CUITControls.HtmlInputButton)sourceControl);
            }
            else if (sourceControl.GetType() == typeof(CUITControls.HtmlLabel))
            {
                control = new HtmlLabel((CUITControls.HtmlLabel)sourceControl);
            }
            else if (sourceControl.GetType() == typeof(CUITControls.HtmlList))
            {
                control = new HtmlList((CUITControls.HtmlList)sourceControl);
            }
            else if (sourceControl.GetType() == typeof(CUITControls.HtmlRadioButton))
            {
                control = new HtmlRadioButton((CUITControls.HtmlRadioButton)sourceControl);
            }
            else if (sourceControl.GetType() == typeof(CUITControls.HtmlSpan))
            {
                control = new HtmlSpan((CUITControls.HtmlSpan)sourceControl);
            }
            else if (sourceControl.GetType() == typeof(CUITControls.HtmlEditableSpan))
            {
                control = new HtmlEditableSpan((CUITControls.HtmlEditableSpan)sourceControl);
            }
            else if (sourceControl.GetType() == typeof(CUITControls.HtmlTable))
            {
                control = new HtmlTable((CUITControls.HtmlTable)sourceControl);
            }
            else if (sourceControl.GetType() == typeof(CUITControls.HtmlCell))
            {
                control = new HtmlCell((CUITControls.HtmlCell)sourceControl);
            }
            else if (sourceControl.GetType() == typeof(CUITControls.HtmlTextArea))
            {
                control = new HtmlTextArea((CUITControls.HtmlTextArea)sourceControl);
            }
            else if (sourceControl.GetType() == typeof(CUITControls.HtmlIFrame))
            {
                control = new HtmlIFrame((CUITControls.HtmlIFrame)sourceControl);
            }
            else if (sourceControl.GetType() == typeof(CUITControls.HtmlListItem))
            {
                control = new HtmlListItem((CUITControls.HtmlListItem)sourceControl);
            }
            else if (sourceControl.GetType() == typeof(CUITControls.HtmlCustom))
            {
                switch (sourceControl.TagName.ToLower())
                {
                    case "p":
                        control = new HtmlParagraph((CUITControls.HtmlCustom)sourceControl);
                        break;
                    case "h1":
                        control = new HtmlHeading1((CUITControls.HtmlCustom)sourceControl);
                        break;
                    case "h2":
                        control = new HtmlHeading2((CUITControls.HtmlCustom)sourceControl);
                        break;
                    case "h3":
                        control = new HtmlHeading3((CUITControls.HtmlCustom)sourceControl);
                        break;
                    case "h4":
                        control = new HtmlHeading4((CUITControls.HtmlCustom)sourceControl);
                        break;
                    case "h5":
                        control = new HtmlHeading5((CUITControls.HtmlCustom)sourceControl);
                        break;
                    case "h6":
                        control = new HtmlHeading6((CUITControls.HtmlCustom)sourceControl);
                        break;
                    case "ul":
                        control = new HtmlUnorderedList((CUITControls.HtmlCustom)sourceControl);
                        break;
                    case "ol":
                        control = new HtmlOrderedList((CUITControls.HtmlCustom)sourceControl);
                        break;
                    case "li":
                        control = new HtmlCustomListItem((CUITControls.HtmlCustom)sourceControl);
                        break;
                    case "ins":
                        control = new HtmlIns((CUITControls.HtmlCustom)sourceControl);
                        break;
                    default:
                        control = new HtmlCustom((CUITControls.HtmlCustom)sourceControl, By.TagName(sourceControl.TagName));
                        break;
                }
            }
            else
            {
                throw new Exception(string.Format("WrapUtil: '{0}' not supported", sourceControl.GetType().Name));
            }
            
            return control;
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