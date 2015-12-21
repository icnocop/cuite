using System;
using CUITe.Controls;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.ObjectRepository
{
    /// <summary>
    /// Abstract class representing a screen or window component in a WPF or WinForms
    /// application.
    /// <para />
    /// In contrast to <see cref="ScreenComponent"/> this class lets you drill down into the UI
    /// control tree, thus rebasing the search for other controls to originate from the control
    /// specified by the search configuration specified in <see cref="ScreenComponent{T}(By)"/>.
    /// </summary>
    /// <remarks>
    /// A <see cref="Screen"/> with a overwhelming number of controls can be split into logical
    /// components, thus providing better test code maintainability.
    /// </remarks>
    /// <seealso cref="Screen"/>
    /// <seealso cref="ScreenComponent"/>
    public abstract class ScreenComponent<T> : ScreenComponent where T : ControlBase
    {
        private readonly By searchConfiguration;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenComponent{T}"/> class.
        /// </summary>
        /// <param name="searchConfiguration">
        /// The search configuration for the control to rebase to.
        /// </param>
        /// <exception cref="InvalidSearchPropertyNamesException">
        /// Search configuration contains a property namely that isn't applicable on the control.
        /// </exception>
        protected ScreenComponent(By searchConfiguration)
        {
            if (searchConfiguration == null)
                throw new ArgumentNullException("searchConfiguration");

            this.searchConfiguration = searchConfiguration;
        }

        /// <summary>
        /// Gets the rebased control specified by the search configuration in
        /// <see cref="ScreenComponent{T}(By)"/>.
        /// </summary>
        public UITestControl Self
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