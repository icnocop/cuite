namespace CUITe.IntegrationTests.NuGet
{
    using System;
    using System.Diagnostics;
    using System.IO;

    /// <summary>
    /// Temporary directory
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public class TempDirectory : IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TempDirectory"/> class.
        /// </summary>
        /// <exception cref="Exception">Failed to get temporary file name without extension</exception>
        public TempDirectory()
        {
            string tempFileName = Path.GetTempFileName();
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(tempFileName);
            if (string.IsNullOrEmpty(fileNameWithoutExtension))
            {
                throw new Exception("Failed to get temporary file name without extension");
            }

            this.DirectoryPath = Path.Combine(Path.GetTempPath(), fileNameWithoutExtension);
            File.Delete(tempFileName);
            Directory.CreateDirectory(this.DirectoryPath);

            this.DeleteDirectoryOnDispose = true;
        }

        /// <summary>
        /// Gets the directory path.
        /// </summary>
        /// <value>
        /// The directory path.
        /// </value>
        public string DirectoryPath { get; internal set; }

        /// <summary>
        /// Gets or sets a value indicating whether to delete the directory on dispose.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the directory is deleted on dispose; otherwise, <c>false</c>.
        /// </value>
        public bool DeleteDirectoryOnDispose { get; set; }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            try
            {
                if ((this.DeleteDirectoryOnDispose) && (Directory.Exists(this.DirectoryPath)))
                {
                    Directory.Delete(this.DirectoryPath, true);
                }
            }
            catch (Exception ex)
            {
                // do not raise exceptions because this is called in a finalizer and may swallow other exceptions
                Trace.WriteLine(string.Format("Failed to delete directory: {0}\r\n{1}", this.DirectoryPath, ex));
            }
        }
    }
}
