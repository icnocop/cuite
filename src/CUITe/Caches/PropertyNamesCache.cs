using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.Caches
{
    /// <summary>
    /// Class that acts as a cache for property names of types implementing
    /// <see cref="UITestControl"/>.
    /// </summary>
    internal class PropertyNamesCache
    {
        private readonly Dictionary<Type, IReadOnlyCollection<string>> cache;

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyNamesCache"/> class.
        /// </summary>
        internal PropertyNamesCache()
        {
            cache = new Dictionary<Type, IReadOnlyCollection<string>>();
        }

        /// <summary>
        /// Gets the property names for specified UI test control type.
        /// </summary>
        /// <typeparam name="T">The UI test control type to get property names for.</typeparam>
        /// <returns>The property names for specified UI test control type.</returns>
        internal IReadOnlyCollection<string> GetPropertyNamesFor<T>() where T : UITestControl
        {
            IReadOnlyCollection<string> propertyNames;
            
            if (!cache.TryGetValue(typeof(T), out propertyNames))
            {
                // Cache miss
                propertyNames = new ReadOnlyCollection<string>(TraversePropertyNamesFor<T>());
                cache[typeof(T)] = propertyNames;
            }

            return propertyNames;
        }

        private static List<string> TraversePropertyNamesFor<T>()
        {
            var propertyNames = new List<string>();

            Type currentType = typeof(T);
            Type currentPropertyNamesType = currentType.GetNestedType("PropertyNames");

            while (currentType != typeof(object))
            {
                if (currentPropertyNamesType != null)
                {
                    IEnumerable<string> currentPropertyNames = currentPropertyNamesType.GetFields()
                        .Select(field => field.Name);

                    propertyNames.AddRange(currentPropertyNames);
                }

                currentType = currentType.BaseType;
                currentPropertyNamesType = currentType.GetNestedType("PropertyNames");
            }

            return propertyNames;
        }
    }
}