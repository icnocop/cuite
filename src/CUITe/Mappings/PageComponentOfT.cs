using System;
using CUITe.Controls;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.Mappings
{
    /// <summary>
    /// Abstract class representing a page component in a HTML application.
    /// <para />
    /// In contrast to <see cref="PageComponent"/> this class lets you drill down into the UI
    /// control tree, thus rebasing the search for other controls to originate from the control
    /// specified by the search configuration specified in <see cref="PageComponent{T}(By)"/>.
    /// </summary>
    /// <remarks>
    /// A <see cref="Page"/> with a overwhelming number of controls can be split into logical
    /// components, thus providing better test code maintainability.
    /// </remarks>
    public class PageComponent<T> : PageComponent where T : ControlBase
    {
        private readonly By searchConfiguration;

        /// <summary>
        /// Initializes a new instance of the <see cref="PageComponent{T}"/> class.
        /// </summary>
        /// <param name="searchConfiguration">
        /// The search configuration for the control to rebase to.
        /// </param>
        /// <exception cref="InvalidSearchPropertyNamesException">
        /// Search configuration contains a property namely that isn't applicable on the control.
        /// </exception>
        protected PageComponent(By searchConfiguration)
        {
            if (searchConfiguration == null)
                throw new ArgumentNullException("searchConfiguration");

            this.searchConfiguration = searchConfiguration;
        }

        /// <summary>
        /// Gets or sets the search limit container.
        /// </summary>
        internal override UITestControl SearchLimitContainer
        {
            get { return base.SearchLimitContainer; }
            set { base.SearchLimitContainer = value.Find<T>(searchConfiguration).SourceControl; }
        }
    }
}