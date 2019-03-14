namespace CUITe.IntegrationTests.NuGet
{
    using System;
    using System.Threading;
    using EnvDTE80;
    using Microsoft.VisualStudio.Shell;

    /// <summary>
    /// Visual Studio Automation
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public class VisualStudioAutomation : IDisposable
    {
        private readonly DTE2 dteInternal;

        private readonly SolutionEventsListener solutionEventsListener;

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualStudioAutomation"/> class.
        /// </summary>
        /// <param name="dte">The DTE.</param>
        public VisualStudioAutomation(DTE2 dte)
        {
            this.dteInternal = dte;

            ServiceProvider serviceProvider = new ServiceProvider(dte as Microsoft.VisualStudio.OLE.Interop.IServiceProvider);

            this.solutionEventsListener = new SolutionEventsListener(serviceProvider);

            this.QuitVisualStudioOnDispose = true;
        }

        /// <summary>
        /// Gets or sets a value indicating whether to quit visual studio on dispose.
        /// </summary>
        /// <value>
        ///   <c>true</c> if visual studio quits on dispose; otherwise, <c>false</c>.
        /// </value>
        public bool QuitVisualStudioOnDispose { get; set; }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
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
