using System;
using System.IO;

namespace Sut.HtmlTest
{
    using System.Collections.Generic;

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

            // add the Mark of the Web (MOTW) so Internet Explorer does not restrict this webpage from running scripts or ActiveX controls
            // https://msdn.microsoft.com/en-us/library/ms537628(v=vs.85).aspx
            // this automatically injects the vsttFireTimer attribute within the body element for some unknown reason
            List<string> fileContents = new List<string>
            {
                "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">",
                "<!-- saved from url=(0014)about:internet -->",
                contents
            };

            File.WriteAllText(FilePath, string.Join(Environment.NewLine, fileContents));

            DeleteFileOnDispose = true;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (DeleteFileOnDispose)
            {
                File.Delete(FilePath);
            }
        }
    }
}
