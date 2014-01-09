using System;
using System.IO;

namespace Sample_CUITeTestProject
{
    /// <summary>
    /// Wrapper for a temporary file
    /// </summary>
    public class TempFile : IDisposable
    {
        /// <summary>
        /// Gets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        public string FilePath { get; private set; }

        public bool DeleteFileOnDispose { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TempFile"/> class.
        /// </summary>
        /// <param name="contents">The contents.</param>
        public TempFile(string contents)
        {
            FilePath = Path.GetTempFileName() + ".html";

            File.WriteAllText(FilePath, contents);

            this.DeleteFileOnDispose = true;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (this.DeleteFileOnDispose)
            {
                File.Delete(FilePath);
            }
        }
    }
}
