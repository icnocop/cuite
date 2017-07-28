using System;

namespace CUITe.IntegrationTests.NuGet
{
    using System.Diagnostics;
    using Microsoft.VisualStudio;
    using Microsoft.VisualStudio.Shell.Interop;

    /// <summary>
    /// Solution Events Listener
    /// </summary>
    /// <seealso cref="Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents" />
    /// <seealso cref="Microsoft.VisualStudio.Shell.Interop.IVsShellPropertyEvents" />
    /// <seealso cref="Microsoft.VisualStudio.Shell.Interop.IVsBroadcastMessageEvents" />
    /// <seealso cref="System.IDisposable" />
    public class SolutionEventsListener : IVsSolutionEvents, IVsShellPropertyEvents, IVsBroadcastMessageEvents, IDisposable
    {
        private IVsSolution solution;

        private IVsShell shell;

        private uint solutionEventsCookie;

        private uint shellPropertyEventsCookie;

        private uint broadcastMessageEventsCookie;

        /// <summary>
        /// Occurs after the solution is loaded.
        /// </summary>
        public event Action AfterSolutionLoaded;

        /// <summary>
        /// Occurs before the solution is closed.
        /// </summary>
        public event Action BeforeSolutionClosed;

        /// <summary>
        /// Occurs after the solution is closed.
        /// </summary>
        public event Action AfterSolutionClosed;

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionEventsListener"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        public SolutionEventsListener(IServiceProvider serviceProvider)
        {
            this.InitNullEvents();

            this.solution = serviceProvider.GetService(typeof(SVsSolution)) as IVsSolution;
            if (this.solution != null)
            {
                this.solution.AdviseSolutionEvents(this, out this.solutionEventsCookie);
            }

            this.shell = (IVsShell)serviceProvider.GetService(typeof(SVsShell));
            if (this.shell != null)
            {
                this.shell.AdviseShellPropertyChanges(this, out this.shellPropertyEventsCookie);
                this.shell.AdviseBroadcastMessages(this, out this.broadcastMessageEventsCookie);
            }
        }

        private void InitNullEvents()
        {
            this.AfterSolutionLoaded += () => { };
            this.BeforeSolutionClosed += () => { };
            this.AfterSolutionClosed += () => { };
        }

        #region IVsSolutionEvents Members

        int IVsSolutionEvents.OnAfterCloseSolution(object pUnkReserved)
        {
            Trace.WriteLine("OnAfterCloseSolution");
            
            if (this.AfterSolutionClosed != null)
            {
                this.AfterSolutionClosed();
            }

            return 0;
        }

        int IVsSolutionEvents.OnAfterLoadProject(IVsHierarchy pStubHierarchy, IVsHierarchy pRealHierarchy)
        {
            Trace.WriteLine("OnAfterLoadProject");
            return 0;
        }

        int IVsSolutionEvents.OnAfterOpenProject(IVsHierarchy pHierarchy, int fAdded)
        {
            Trace.WriteLine("OnAfterOpenProject");
            return 0;
        }

        int IVsSolutionEvents.OnAfterOpenSolution(object pUnkReserved, int fNewSolution)
        {
            Trace.WriteLine("OnAfterOpenSolution");

            if (this.AfterSolutionLoaded != null)
            {
                this.AfterSolutionLoaded();
            }

            return 0;
        }

        int IVsSolutionEvents.OnBeforeCloseProject(IVsHierarchy pHierarchy, int fRemoved)
        {
            Trace.WriteLine("OnBeforeCloseProject");
            return 0;
        }

        int IVsSolutionEvents.OnBeforeCloseSolution(object pUnkReserved)
        {
            Trace.WriteLine("OnBeforeCloseSolution");

            if (this.BeforeSolutionClosed != null)
            {
                this.BeforeSolutionClosed();
            }

            return 0;
        }

        int IVsSolutionEvents.OnBeforeUnloadProject(IVsHierarchy pRealHierarchy, IVsHierarchy pStubHierarchy)
        {
            Trace.WriteLine("OnBeforeUnloadProject");
            return 0;
        }

        int IVsSolutionEvents.OnQueryCloseProject(IVsHierarchy pHierarchy, int fRemoving, ref int pfCancel)
        {
            Trace.WriteLine("OnQueryCloseProject");
            return 0;
        }

        int IVsSolutionEvents.OnQueryCloseSolution(object pUnkReserved, ref int pfCancel)
        {
            Trace.WriteLine("OnQueryCloseSolution");
            return 0;
        }

        int IVsSolutionEvents.OnQueryUnloadProject(IVsHierarchy pRealHierarchy, ref int pfCancel)
        {
            Trace.WriteLine("OnQueryUnloadProject");
            return 0;
        }

        #endregion

        #region IDisposable Members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (this.solution != null && this.solutionEventsCookie != 0)
            {
                GC.SuppressFinalize(this);
                this.solution.UnadviseSolutionEvents(this.solutionEventsCookie);

                this.AfterSolutionLoaded = null;
                this.BeforeSolutionClosed = null;
                this.AfterSolutionClosed = null;

                this.solutionEventsCookie = 0;
                this.solution = null;
            }

            if (this.shell != null)
            {
                if (this.shellPropertyEventsCookie != 0)
                {
                    this.shell.UnadviseShellPropertyChanges(this.shellPropertyEventsCookie);
                    this.shellPropertyEventsCookie = 0;
                }

                if (this.broadcastMessageEventsCookie != 0)
                {
                    this.shell.UnadviseBroadcastMessages(this.broadcastMessageEventsCookie);
                    this.broadcastMessageEventsCookie = 0;
                }
                
                this.shell = null;
            }
        }

        #endregion

        /// <summary>
        /// Called when a shell property changes.
        /// </summary>
        /// <param name="propid">The property identifier.</param>
        /// <param name="var">The variable.</param>
        /// <returns></returns>
        public int OnShellPropertyChange(int propid, object var)
        {
            Trace.WriteLine(string.Format("Shell Property Changed '{0} '{1}'", propid, var));

            return VSConstants.S_OK;
        }

        /// <summary>
        /// Called when a message is broadcast.
        /// </summary>
        /// <param name="msg">The message identifier.</param>
        /// <param name="wParam">The first parameter.</param>
        /// <param name="lParam">The second parameter.</param>
        /// <returns></returns>
        public int OnBroadcastMessage(uint msg, IntPtr wParam, IntPtr lParam)
        {
            Trace.WriteLine(string.Format("Broadcast Message '{0} '{1}' '{2}'", msg, wParam, lParam));

            return VSConstants.S_OK;
        }
    }
}
