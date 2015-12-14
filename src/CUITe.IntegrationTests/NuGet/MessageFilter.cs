using System;

namespace CUITe.IntegrationTests.NuGet
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// OLE Message filter for thread error-handling
    /// </summary>
    public class MessageFilter : IOleMessageFilter
    {
        /// <summary>
        /// Registers this instance.
        /// </summary>
        public static void Register()
        {
            IOleMessageFilter newFilter = new MessageFilter();
            IOleMessageFilter oldFilter;
            CoRegisterMessageFilter(newFilter, out oldFilter);
        }

        /// <summary>
        /// Revokes this instance.
        /// </summary>
        public static void Revoke()
        {
            IOleMessageFilter oldFilter;
            CoRegisterMessageFilter(null, out oldFilter);
        }

        /// <summary>
        /// Handles the incoming thread requests.
        /// </summary>
        /// <param name="dwCallType">Type of the call.</param>
        /// <param name="hTaskCaller">The handle to the task caller.</param>
        /// <param name="dwTickCount">The tick count.</param>
        /// <param name="lpInterfaceInfo">The interface information.</param>
        /// <returns>Zero</returns>
        int IOleMessageFilter.HandleInComingCall(
            int dwCallType,
            IntPtr hTaskCaller,
            int dwTickCount,
            IntPtr lpInterfaceInfo)
        {
            //Return the flag SERVERCALL_ISHANDLED.
            return 0;
        }

        /// <summary>
        /// Retries the rejected call.
        /// </summary>
        /// <param name="hTaskCallee">The handle to the task callee.</param>
        /// <param name="dwTickCount">The tick count.</param>
        /// <param name="dwRejectType">Type of the reject call.</param>
        /// <returns>99 to retry or -1 to cancel</returns>
        int IOleMessageFilter.RetryRejectedCall(
            IntPtr hTaskCallee,
            int dwTickCount,
            int dwRejectType)
        {
            if (dwRejectType == 2)
            // flag = SERVERCALL_RETRYLATER.
            {
                // Retry the thread call immediately if return >=0 & 
                // <100.
                return 99;
            }
            // Too busy; cancel call.
            return -1;
        }

        /// <summary>
        /// Messages the pending.
        /// </summary>
        /// <param name="hTaskCallee">The handle to the task callee.</param>
        /// <param name="dwTickCount">The tick count.</param>
        /// <param name="dwPendingType">Type of the pending call.</param>
        /// <returns>2</returns>
        int IOleMessageFilter.MessagePending(
            IntPtr hTaskCallee,
            int dwTickCount,
            int dwPendingType)
        {
            //Return the flag PENDINGMSG_WAITDEFPROCESS.
            return 2;
        }

        [DllImport("Ole32.dll")]
        private static extern int
          CoRegisterMessageFilter(IOleMessageFilter newFilter, out 
          IOleMessageFilter oldFilter);
    }

    [ComImport, Guid("00000016-0000-0000-C000-000000000046"),
    InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    interface IOleMessageFilter
    {
        [PreserveSig]
        int HandleInComingCall(
            int dwCallType,
            IntPtr hTaskCaller,
            int dwTickCount,
            IntPtr lpInterfaceInfo);

        [PreserveSig]
        int RetryRejectedCall(
            IntPtr hTaskCallee,
            int dwTickCount,
            int dwRejectType);

        [PreserveSig]
        int MessagePending(
            IntPtr hTaskCallee,
            int dwTickCount,
            int dwPendingType);
    }
}
