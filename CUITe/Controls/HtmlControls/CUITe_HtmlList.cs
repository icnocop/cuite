using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlList : CUITe_HtmlControl<HtmlList>
    {
        public CUITe_HtmlList() : base() { }
        public CUITe_HtmlList(string searchParameters) : base(searchParameters) { }

        /// <summary>
        /// Gets the items in a string array of the html list.
        /// </summary>
        public string[] Items
        {
            get
            {
                return GetPropertyOfChildren<string>(HtmlControl.PropertyNames.InnerText);
            }
        }

        /// <summary>
        /// Tells whether the specified item is present in the html list or not.
        /// </summary>
        public bool ItemExists(string sText)
        {
            return this.Items.Contains<string>(sText);
        }
    }
}
