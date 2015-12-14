namespace CUITe.IntegrationTests.NuGet
{
    using System;
    using System.Threading;
    using EnvDTE;
    using Microsoft.VisualStudio.Shell;

    public class VisualStudioAutomation : IDisposable
    {
        private readonly DTE dteInternal;

        private readonly SolutionEventsListener solutionEventsListener;

        public VisualStudioAutomation(DTE dte)
        {
            this.dteInternal = dte;

            ServiceProvider serviceProvider = new ServiceProvider(dte as Microsoft.VisualStudio.OLE.Interop.IServiceProvider);
            
            this.solutionEventsListener = new SolutionEventsListener(serviceProvider);

            this.QuitVisualStudioOnDispose = true;
        }

        public bool QuitVisualStudioOnDispose { get; set; }

        public void Dispose()
        {
            if (!this.QuitVisualStudioOnDispose)
            {
                return;
            }

            AutoResetEvent autoResetEvent = new AutoResetEvent(false);

            this.solutionEventsListener.AfterSolutionClosed += () => { autoResetEvent.Set(); };

            this.dteInternal.Quit();

            autoResetEvent.WaitOne();
        }
    }
}
