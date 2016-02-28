using System;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a list control for web page user interface (UI) testing.
    /// </summary>
    public class HtmlList : HtmlControl<CUITControls.HtmlList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlList"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlList(By searchConfiguration = null)
            : this(new CUITControls.HtmlList(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlList"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlList(CUITControls.HtmlList sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
        
        /// <summary>
        /// Gets a collection of items in this list.
        /// </summary>
        public string[] Items
        {
            get
            {
                // Trying to call InnerText of children will cause errors if child items are
                // disabled
                return InnerText.Split(
                    new[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);
            }
        }

        /// <summary>
        /// Gets or sets an array of the selected items.
        /// </summary>
        public string[] SelectedItems
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.SelectedItems;
            }
            set
            {
                WaitForControlReadyIfNecessary();
                SourceControl.SelectedItems = value;
            }
        }
    }
}