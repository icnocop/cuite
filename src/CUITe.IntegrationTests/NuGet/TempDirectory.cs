namespace CUITe.IntegrationTests.NuGet
{
    using System;
    using System.Diagnostics;
    using System.IO;

    public class TempDirectory : IDisposable
    {
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
