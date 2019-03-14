using System;
using CUITe.Controls;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.PageObjects
{
    /// <summary>
    /// Abstract class representing a page object in a HTML or Silverlight application.
    /// <para />
    /// In contrast to <see cref="PageObject"/> this class lets you drill down into the UI
    /// control tree, thus rebasing the search for other controls to originate from the control
    /// specified by the search configuration specified in <see cref="PageObject{T}(By)"/>.
    /// </summary>
    /// <remarks>
    /// A <see cref="Page"/> with a overwhelming number of controls can be split into logical
    /// page objects, thus providing better test code maintainability.
    /// </remarks>
    /// <seealso cref="Page"/>
    /// <seealso cref="PageObject"/>
    public class PageObject<T> : PageObject where T : ControlBase
    {
        private readonly By searchConfiguration;

        /// <summary>
        /// Initializes a new instance of the <see cref="PageObject{T}"/> class.
        /// </summary>
        /// <param name="searchConfiguration">
        /// The search configuration for the control to rebase to.
        /// </param>
        protected PageObject(By searchConfiguration)
        {
            if (searchConfiguration == null)
                throw new ArgumentNullException("searchConfiguration");

            this.searchConfiguration = searchConfiguration;
        }

        /// <summary>
        /// Gets the rebased control specified by the search configuration in
        /// <see cref="PageObject{T}(By)" />.
        /// </summary>
        public new UITestControl Self
        {
            get { return SearchLimitContainer; }
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