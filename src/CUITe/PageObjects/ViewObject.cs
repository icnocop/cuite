using System;
using CUITe.Controls;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.PageObjects
{
    /// <summary>
    /// Base class for all view objects, indifferent of application technology.
    /// </summary>
    public abstract class ViewObject
    {
        private UITestControl searchLimitContainer;

        /// <summary>
        /// Highlights the control.
        /// </summary>
        public void DrawHighlight()
        {
            searchLimitContainer.DrawHighlight();
        }

        /// <summary>
        /// Gets the control object represented by the view object.
        /// </summary>
        public ControlBase Self
        {
            get { return ControlBaseFactory.Create(searchLimitContainer); }
        }

        /// <summary>
        /// Gets or sets the search limit container.
        /// </summary>
        internal virtual UITestControl SearchLimitContainer
        {
            get { return searchLimitContainer; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                searchLimitContainer = value;
            }
        }

        /// <summary>
        /// Finds the control object from the descendants of this control using the specified
        /// search configuration.
        /// </summary>
        /// <typeparam name="T">The type of control to find.</typeparam>
        /// <param name="searchConfiguration">The search configuration.</param>
        protected T Find<T>(By searchConfiguration = null) where T : ControlBase
        {
            if (searchLimitContainer == null)
                throw new InvalidOperationException("The view object has not been configured with a search limit container.");

            return searchLimitContainer.Find<T>(searchConfiguration);
        }
    }
}