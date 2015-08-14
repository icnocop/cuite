using System;
using System.Linq;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlList : HtmlControl<CUITControls.HtmlList>
    {
        public HtmlList()
        {
        }

        public HtmlList(string searchParameters)
            : base(searchParameters)
        {
        }

        /// <summary>
        /// Gets the items in a string array of the html list.
        /// </summary>
        public string[] Items
        {
            get
            {
                //trying to call InnerText of children will cause errors if child items are disabled
                return InnerText.Split(
                    new[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);
            }
        }

        /// <summary>
        /// Tells whether the specified item is present in the html list or not.
        /// </summary>
        public bool ItemExists(string sText)
        {
            return Items.Contains(sText);
        }

        /// <summary>
        /// Gets or sets the selected items.
        /// </summary>
        /// <value>
        /// The selected items.
        /// </value>
        public string[] SelectedItems
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.SelectedItems;
            }
            set
            {
                SourceControl.WaitForControlReady();
                SourceControl.SelectedItems = value;
            }
        }
    }
}