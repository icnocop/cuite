using System;

namespace CUITe.IntegrationTests.NuGet
{
    using System.IO;

    public class TempFile : IDisposable
    {
        readonly string tempFilePath = Path.GetTempFileName();

        public string FilePath
        {
            get
            {
                return this.tempFilePath;
            }
        }

        public void Dispose()
        {
            if (File.Exists(this.tempFilePath))
            {
                File.Delete(this.tempFilePath);
            }
        }
    }
}
