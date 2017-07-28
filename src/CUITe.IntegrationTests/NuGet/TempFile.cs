using System;

namespace CUITe.IntegrationTests.NuGet
{
    using System.IO;

    /// <summary>
    /// Temporary file
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public class TempFile : IDisposable
    {
        readonly string tempFilePath = Path.GetTempFileName();

        /// <summary>
        /// Gets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        public string FilePath
        {
            get
            {
                return this.tempFilePath;
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (File.Exists(this.tempFilePath))
            {
                File.Delete(this.tempFilePath);
            }
        }
    }
}
