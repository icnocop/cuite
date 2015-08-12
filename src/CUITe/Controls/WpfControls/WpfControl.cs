using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Base wrapper class for all CUITe_Wpf* controls, inherits from CUITe_ControlBase
    /// </summary>
    /// <typeparam name="T">The Coded UI WpfControl type</typeparam>
    public class WpfControl<T> : ControlBase<T> where T : CUITControls.WpfControl
    {
        public WpfControl() : base() { }
        public WpfControl(string searchParameters) : base(searchParameters) { }

        /// <summary>
        /// Gets the parent of the current CUITe control.
        /// </summary>
        public override IControlBase Parent
        {
            get
            {
                this._control.WaitForControlReady();
                
                IControlBase ret = null;
                
                try
                {
                    ret = WpfControlFactory.Create((CUITControls.WpfControl)this._control.GetParent());
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    throw new InvalidTraversalException(string.Format("({0}).Parent", this._control.GetType().Name));
                }
                return ret;
            }
        }


        /// <summary>
        /// Wrap AcceleratorKey property common to all WPF controls
        /// </summary>
        public string AcceleratorKey
        {
            get { return this.UnWrap().AcceleratorKey; }
        }

        /// <summary>
        /// Wrap AccessKey property common to all WPF controls
        /// </summary>
        public string AccessKey
        {
            get { return this.UnWrap().AccessKey; }
        }

        /// <summary>
        /// Wrap AutomationId property common to all WPF controls
        /// </summary>
        public string AutomationId
        {
            get { return this.UnWrap().AutomationId; }
        }

        /// <summary>
        /// Wrap Font property common to all WPF controls
        /// </summary>
        public string Font
        {
            get { return this.UnWrap().Font; }
        }

        /// <summary>
        /// Wrap HelpText property common to all WPF controls
        /// </summary>
        public string HelpText
        {
            get { return this.UnWrap().HelpText; }
        }

        /// <summary>
        /// Wrap LabeledBy property common to all WPF controls
        /// </summary>
        public string LabeledBy
        {
            get { return this.UnWrap().LabeledBy; }
        }
    }
}
