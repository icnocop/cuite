using System;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.Controls
{
    /// <summary>
    /// Base class for all UI test controls. It provides properties and methods which are generic
    /// to controls across technologies.
    /// </summary>
    /// <typeparam name="T">The type of the <see cref="SourceControl"/>.</typeparam>
    public abstract class ControlBase<T> : ControlBase where T : UITestControl
    {
        private readonly T sourceControl;

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlBase{T}"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        /// <exception cref="InvalidSearchPropertiesFormatException">
        /// Search properties are not correctly formatted.
        /// </exception>
        /// <exception cref="InvalidSearchKeyException">
        /// Search properties contains key that isn't applicable on the control.
        /// </exception>
        protected ControlBase(T sourceControl, By searchConfiguration = null)
            : base(sourceControl)
        {
            if (sourceControl == null)
                throw new ArgumentNullException("sourceControl");

            this.sourceControl = sourceControl;

            if (searchConfiguration != null)
            {
                AddSearchProperties(searchConfiguration.InternalSearchProperties);
            }
        }

        /// <summary>
        /// Gets the source control.
        /// </summary>
        public new T SourceControl
        {
            get { return sourceControl; }
        }

        /// <summary>
        /// Finds the control object from the descendants of this control using the specified
        /// search properties.
        /// </summary>
        /// <typeparam name="TControl">The type of control to find.</typeparam>
        /// <param name="searchConfiguration">The search configuration.</param>
        /// <exception cref="InvalidSearchPropertiesFormatException">
        /// Search properties are not correctly formatted.
        /// </exception>
        /// <exception cref="InvalidSearchKeyException">
        /// Search properties contains key that isn't applicable on the control.
        /// </exception>
        public TControl Find<TControl>(By searchConfiguration = null) where TControl : ControlBase
        {
            var control = ControlBaseFactory.Create<TControl>(searchConfiguration);
            control.SourceControl.Container = sourceControl;
            return control;
        }
    }
}