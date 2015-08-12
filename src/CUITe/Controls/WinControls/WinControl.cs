using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Base wrapper class for all CUITe_Win* controls, inherits from CUITe_ControlBase
    /// </summary>
    /// <typeparam name="T">The Coded UI WinControl type</typeparam>
    public class WinControl<T> : CUITe_ControlBase<T> where T : CUIT.WinControl
    {
        public WinControl() : base() { }
        public WinControl(string searchParameters) : base(searchParameters) { }

        /// <summary>
        /// Gets the parent of the current CUITe control.
        /// </summary>
        public override ICUITe_ControlBase Parent
        {
            get
            {
                this._control.WaitForControlReady();
                
                ICUITe_ControlBase ret = null;
                
                try
                {
                    ret = WinControlFactory.Create((CUIT.WinControl)this._control.GetParent());
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    throw new CUITe_InvalidTraversal(string.Format("({0}).Parent", this._control.GetType().Name));
                }
                return ret;
            }
        }
    }
}
