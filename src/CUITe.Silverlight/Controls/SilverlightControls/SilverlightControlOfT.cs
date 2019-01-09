using CUITe.SearchConfigurations;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Base class for all test controls in the user interface (UI) of a Silverlight application.
    /// </summary>
    /// <typeparam name="T">The source control type.</typeparam>
    public abstract class SilverlightControl<T> : ControlBase<T> where T : CUITControls.SilverlightControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightControl{T}"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        protected SilverlightControl(T sourceControl, By searchConfiguration)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the control's label text.
        /// </summary>
        public string LabeledBy
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.LabeledBy;
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
                    return WrapUtil((CUITControls.SilverlightControl)SourceControl.GetParent());
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
                    return WrapUtil((CUITControls.SilverlightControl)SourceControl.GetParent().GetChildren()[GetMyIndexAmongSiblings() - 1]);
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
                    return WrapUtil((CUITControls.SilverlightControl)SourceControl.GetParent().GetChildren()[GetMyIndexAmongSiblings() + 1]);
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
                    return WrapUtil((CUITControls.SilverlightControl)SourceControl.GetChildren()[0]);
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
            var uicol = new List<ControlBase>();
            foreach (UITestControl uitestcontrol in SourceControl.GetChildren())
            {
                uicol.Add(WrapUtil((CUITControls.SilverlightControl)uitestcontrol));
            }
            return uicol;
        }

        private ControlBase WrapUtil(CUITControls.SilverlightControl control)
        {
            ControlBase _con = null;
            if (control.GetType() == typeof(CUITControls.SilverlightButton))
            {
                _con = new SilverlightButton((CUITControls.SilverlightButton)control);
            }
            else if (control.GetType() == typeof(CUITControls.SilverlightCalendar))
            {
                _con = new SilverlightCalendar((CUITControls.SilverlightCalendar)control);
            }
            else if (control.GetType() == typeof(CUITControls.SilverlightCell))
            {
                _con = new SilverlightCell((CUITControls.SilverlightCell)control);
            }
            else if (control.GetType() == typeof(CUITControls.SilverlightCheckBox))
            {
                _con = new SilverlightCheckBox((CUITControls.SilverlightCheckBox)control);
            }
            else if (control.GetType() == typeof(CUITControls.SilverlightChildWindow))
            {
                _con = new SilverlightChildWindow((CUITControls.SilverlightChildWindow)control);
            }
            else if (control.GetType() == typeof(CUITControls.SilverlightComboBox))
            {
                _con = new SilverlightComboBox((CUITControls.SilverlightComboBox)control);
            }
            else if (control.GetType() == typeof(CUITControls.SilverlightDataPager))
            {
                _con = new SilverlightDataPager((CUITControls.SilverlightDataPager)control);
            }
            else if (control.GetType() == typeof(CUITControls.SilverlightDatePicker))
            {
                _con = new SilverlightDatePicker((CUITControls.SilverlightDatePicker)control);
            }
            else if (control.GetType() == typeof(CUITControls.SilverlightEdit))
            {
                _con = new SilverlightEdit((CUITControls.SilverlightEdit)control);
            }
            else if (control.GetType() == typeof(CUITControls.SilverlightHyperlink))
            {
                _con = new SilverlightHyperlink((CUITControls.SilverlightHyperlink)control);
            }
            else if (control.GetType() == typeof(CUITControls.SilverlightImage))
            {
                _con = new SilverlightImage((CUITControls.SilverlightImage)control);
            }
            else if (control.GetType() == typeof(CUITControls.SilverlightLabel))
            {
                _con = new SilverlightLabel((CUITControls.SilverlightLabel)control);
            }
            else if (control.GetType() == typeof(CUITControls.SilverlightList))
            {
                _con = new SilverlightList((CUITControls.SilverlightList)control);
            }
            else if (control.GetType() == typeof(CUITControls.SilverlightListItem))
            {
                _con = new SilverlightListItem((CUITControls.SilverlightListItem)control);
            }
            else if (control.GetType() == typeof(CUITControls.SilverlightRadioButton))
            {
                _con = new SilverlightRadioButton((CUITControls.SilverlightRadioButton)control);
            }
            else if (control.GetType() == typeof(CUITControls.SilverlightSlider))
            {
                _con = new SilverlightSlider((CUITControls.SilverlightSlider)control);
            }
            else if (control.GetType() == typeof(CUITControls.SilverlightTab))
            {
                _con = new SilverlightTab((CUITControls.SilverlightTab)control);
            }
            else if (control.GetType() == typeof(CUITControls.SilverlightTabItem))
            {
                _con = new SilverlightTabItem((CUITControls.SilverlightTabItem)control);
            }
            else if (control.GetType() == typeof(CUITControls.SilverlightTable))
            {
                _con = new SilverlightTable((CUITControls.SilverlightTable)control);
            }
            else if (control.GetType() == typeof(CUITControls.SilverlightText))
            {
                _con = new SilverlightText((CUITControls.SilverlightText)control);
            }
            else if (control.GetType() == typeof(CUITControls.SilverlightTree))
            {
                _con = new SilverlightTree((CUITControls.SilverlightTree)control);
            }
            else if (control.GetType() == typeof(CUITControls.SilverlightControl))
            {
                _con = new SilverlightControl(control);
            }
            else
            {
                throw new Exception(string.Format("WrapUtil: '{0}' is not supported.", control.GetType()));
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
