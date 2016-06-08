using System;
using CUITe.Controls;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.ScreenObjects
{
    /// <summary>
    /// Abstract class representing a screen or window object in a WPF or WinForms
    /// application.
    /// <para />
    /// In contrast to <see cref="ScreenObject"/> this class lets you drill down into the UI
    /// control tree, thus rebasing the search for other controls to originate from the control
    /// specified by the search configuration specified in <see cref="ScreenObject{T}(By)"/>.
    /// </summary>
    /// <remarks>
    /// A <see cref="Screen"/> with a overwhelming number of controls can be split into logical
    /// screen objects, thus providing better test code maintainability.
    /// </remarks>
    /// <seealso cref="Screen"/>
    /// <seealso cref="ScreenObject"/>
    public abstract class ScreenObject<T> : ScreenObject where T : ControlBase
    {
        private readonly By searchConfiguration;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenObject{T}"/> class.
        /// </summary>
        /// <param name="searchConfiguration">
        /// The search configuration for the control to rebase to.
        /// </param>
        protected ScreenObject(By searchConfiguration)
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