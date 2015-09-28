using System;

namespace CUITe.DataSources
{
    /// <summary>
    /// Exception thrown by <see cref="XmlDataSource"/> when requesting a data block with id that
    /// isn't found.
    /// </summary>
    public class DataBlockIdNotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataBlockIdNotFoundException"/> class.
        /// </summary>
        /// <param name="id">The data block id.</param>
        public DataBlockIdNotFoundException(string id)
            : base(string.Format("A data block id '{0}' wasn't found.", id))
        {
        }
    }
}