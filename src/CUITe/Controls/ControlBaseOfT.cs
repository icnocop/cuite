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
        protected ControlBase(T sourceControl, By searchConfiguration = null)
            : base(sourceControl)
        {
            if (sourceControl == null)
                throw new ArgumentNullException("sourceControl");

            this.sourceControl = sourceControl;

            if (searchConfiguration != null)
            {
                AddSearchProperties(searchConfiguration.Configuration);
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
        /// search configuration.
        /// </summary>
        /// <typeparam name="TControl">The type of control to find.</typeparam>
        /// <param name="searchConfiguration">The search configuration.</param>
        public TControl Find<TControl>(By searchConfiguration = null) where TControl : ControlBase
        {
            return sourceControl.Find<TControl>(searchConfiguration);
        }

        /// <summary>
        /// Adds a search property by using the provided property name, value, and operator.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <param name="propertyValue">The property value to search for.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        internal void AddSearchProperty(
            string propertyName,
            string propertyValue,
            PropertyExpressionOperator conditionOperator = PropertyExpressionOperator.EqualTo)
        {
            var searchProperties = new PropertyExpressionCollection
            {
                new PropertyExpression(propertyName, propertyValue, conditionOperator)
            };

            AddSearchProperties(searchProperties);
        }

        /// <summary>
        /// Adds all search property in the provided collection.
        /// </summary>
        /// <param name="searchProperties">The search properties.</param>
        internal virtual void AddSearchProperties(PropertyExpressionCollection searchProperties)
        {
            if (searchProperties == null)
                throw new ArgumentNullException("searchProperties");

            SourceControl.SearchProperties.AddRange(searchProperties);
        }

        /// <summary>
        /// Returns a search property that has a property name that matches the provided property
        /// name.
        /// </summary>
        /// <param name="propertyName">
        /// The property name for a <see cref="PropertyExpression"/> to find.
        /// </param>
        /// <returns>
        /// A <see cref="PropertyExpression"/> object, if one is found; otherwise, null.
        /// </returns>
        internal PropertyExpression GetSearchProperty(string propertyName)
        {
            return SourceControl.SearchProperties.Find(propertyName);
        }
    }
}