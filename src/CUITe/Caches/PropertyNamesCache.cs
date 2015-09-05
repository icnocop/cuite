using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.Caches
{
    /// <summary>
    /// Class that acts as a cache for property names of types implementing
    /// <see cref="UITestControl"/>.
    /// </summary>
    public class PropertyNamesCache
    {
        private readonly Dictionary<Type, IEnumerable<string>> cache;

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyNamesCache"/> class.
        /// </summary>
        public PropertyNamesCache()
        {
            cache = new Dictionary<Type, IEnumerable<string>>();
        }

        /// <summary>
        /// Gets the property names for specified UI test control type.
        /// </summary>
        /// <typeparam name="T">The UI test control type to get property names for.</typeparam>
        /// <returns>The property names for specified UI test control type.</returns>
        public IEnumerable<string> GetPropertyNamesFor<T>() where T : UITestControl
        {
            IEnumerable<string> propertyNames;
            
            if (!cache.TryGetValue(typeof(T), out propertyNames))
            {
                // Cache miss
                propertyNames = TraversePropertyNamesFor<T>();
                cache[typeof(T)] = propertyNames;
            }

            return propertyNames;
        }

        private static IEnumerable<string> TraversePropertyNamesFor<T>()
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