using System;
using System.IO;

namespace TestHelpers
{
    /// <summary>
    /// Class acting as a wrapper for a temporary HTML file.
    /// </summary>
    public class TempWebPage : IDisposable
    {
        private readonly string filePath;

        /// <summary>
        /// Initializes a new instance of the <see cref="TempWebPage"/> class.
        /// </summary>
        /// <param name="content">The content of the web page.</param>
        public TempWebPage(string content)
        {
            if (content == null)
                throw new ArgumentNullException("content");

            filePath = Path.GetTempFileName() + ".html";

            // Add the Mark of the Web (MOTW) so Internet Explorer does not restrict this webpage
            // from running scripts or ActiveX controls. For more information see
            // https://msdn.microsoft.com/en-us/library/ms537628(v=vs.85).aspx
            content =
                "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">" + Environment.NewLine +
                "<!-- saved from url=(0016)http://localhost -->" + Environment.NewLine +
                content;

            File.WriteAllText(FilePath, content);
        }

        /// <summary>
        /// Gets the file path.
        /// </summary>
        public string FilePath
        {
            get { return filePath; }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting
        /// unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            File.Delete(FilePath);
        }
    }
}