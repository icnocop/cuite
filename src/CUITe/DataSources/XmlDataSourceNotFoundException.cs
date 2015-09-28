using System;
using System.Reflection;

namespace CUITe.DataSources
{
    /// <summary>
    /// Exception thrown by <see cref="XmlDataSource"/> when the specified XML data source isn't
    /// found.
    /// </summary>
    public class XmlDataSourceNotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XmlDataSourceNotFoundException"/> class.
        /// </summary>
        /// <param name="assembly">The assembly.</param>
        /// <param name="type">The type.</param>
        /// <param name="fileName">Name of the file.</param>
        public XmlDataSourceNotFoundException(Assembly assembly, Type type, string fileName)
            : base(string.Format("Failed to get resource '{0}' from type '{1}' in assembly '{2}'.", fileName, type, assembly.FullName))
        {
        }
    }
}