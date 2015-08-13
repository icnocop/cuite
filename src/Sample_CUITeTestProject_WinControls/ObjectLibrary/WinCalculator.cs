using CUITe.Controls.WinControls;

namespace Sample_CUITeTestProject_WinControls.ObjectLibrary
{
    public class WinCalculator : WinWindow
    {
        public WinCalculator() : base("Name=Calculator") { }

        public WinMenuBar mbApplication { get { return Get<WinMenuBar>("Name=Application"); } }
        public WinMenuItem miView { get { return Get<WinMenuItem>("Name=View"); } }
        public WinMenuItem miStandard { get { return miView.Get<WinMenuItem>("Name~Standard"); } }
        public WinMenuItem miScientific { get { return miView.Get<WinMenuItem>("Name~Scientific"); } }
        public WinMenuItem miBasic { get { return miView.Get<WinMenuItem>("Name~Basic"); } }
        public WinMenuItem miWorksheets { get { return miView.Get<WinMenuItem>("Name~Worksheets"); } }
        public WinMenuItem miLease { get { return miView.Get<WinMenuItem>("Name~Vehicle lease"); } }

        public WinButton btnClear { get { return Get<WinButton>("Name=Clear"); } }

        public WinRadioButton rbDegrees { get { return Get<WinRadioButton>("Name=Radians"); } }
        public WinRadioButton rbRadians { get { return Get<WinRadioButton>("Name=Degrees"); } }
        public WinRadioButton rbGrads { get { return Get<WinRadioButton>("Name=Grads"); } }

        public WinButton btn0 { get { return Get<WinButton>("Name=0"); } }
        public WinButton btn1 { get { return Get<WinButton>("Name=1"); } }
        public WinButton btn2 { get { return Get<WinButton>("Name=2"); } }
        public WinButton btn3 { get { return Get<WinButton>("Name=3"); } }
        public WinButton btn4 { get { return Get<WinButton>("Name=4"); } }
        public WinButton btn5 { get { return Get<WinButton>("Name=5"); } }
        public WinButton btn6 { get { return Get<WinButton>("Name=6"); } }
        public WinButton btn7 { get { return Get<WinButton>("Name=7"); } }
        public WinButton btn8 { get { return Get<WinButton>("Name=8"); } }
        public WinButton btn9 { get { return Get<WinButton>("Name=9"); } }
        public WinButton btnAdd { get { return Get<WinButton>("Name=Add"); } }
        public WinButton btnSubtract { get { return Get<WinButton>("Name=Subtract"); } }
        public WinButton btnMultiply { get { return Get<WinButton>("Name=Multiply"); } }
        public WinButton btnDivide { get { return Get<WinButton>("Name=Divide"); } }
        public WinButton btnEquals { get { return Get<WinButton>("Name=Equals"); } }

        public WinText txtResult { get { return Get<WinText>("Name=Result"); } }
    }
}
