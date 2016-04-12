using System;
using System.Text;

namespace TestHelpers
{
    using System.Diagnostics;
    using System.Threading;

    public static class ProcessRunner
    {
        public static RunResult Run(
           string fileName,
           string arguments)
        {
            RunResult runResult = new RunResult();

            using (Process process = new Process
            {
                StartInfo = new ProcessStartInfo(fileName, arguments)
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    FileName = fileName,
                    Arguments = arguments
                }
            })
            {
                StringBuilder output = new StringBuilder();
                StringBuilder error = new StringBuilder();

                Action<string, string, AutoResetEvent, StringBuilder> dataReceivedHandler = (prefix, data, autoResetEvent, stringBuilder) =>
                {
                    if (data == null)
                    {
                        autoResetEvent.Set();
                    }
                    else
                    {
                        string message = string.Format("[{0}] {1}: {2}", DateTime.Now, prefix, data);
                        Trace.WriteLine(message);
                        stringBuilder.AppendLine(message);
                    }
                };

                using (AutoResetEvent outputWaitHandle = new AutoResetEvent(false))
                using (AutoResetEvent errorWaitHandle = new AutoResetEvent(false))
                {
                    process.OutputDataReceived += (sender, e) => dataReceivedHandler("OUT", e.Data, outputWaitHandle, output);
                    process.ErrorDataReceived += (sender, e) => dataReceivedHandler("ERR", e.Data, errorWaitHandle, error);

                    Trace.WriteLine(string.Format("\"{0}\" {1}", fileName, arguments));

                    process.Start();

                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    process.WaitForExit();

                    // process completed
                    runResult.ExitCode = process.ExitCode;
                    runResult.StandardOutput = output.ToString();
                    runResult.StandardError = error.ToString();
                }
            }

            return runResult;
        }
    }
}
