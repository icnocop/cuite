using CUITe.Controls.WinControls;

namespace Sample_CUITeTestProject_WinControls.ObjectLibrary
{
    public class winCalculator : CUITe_WinWindow
    {
        public winCalculator() : base("Name=Calculator") { }

        public CUITe_WinMenuBar mbApplication { get { return Get<CUITe_WinMenuBar>("Name=Application"); } }
        public CUITe_WinMenuItem miView { get { return Get<CUITe_WinMenuItem>("Name=View"); } }
        public CUITe_WinMenuItem miStandard { get { return miView.Get<CUITe_WinMenuItem>("Name~Standard"); } }
        public CUITe_WinMenuItem miScientific { get { return miView.Get<CUITe_WinMenuItem>("Name~Scientific"); } }
        public CUITe_WinMenuItem miBasic { get { return miView.Get<CUITe_WinMenuItem>("Name~Basic"); } }
        public CUITe_WinMenuItem miWorksheets { get { return miView.Get<CUITe_WinMenuItem>("Name~Worksheets"); } }
        public CUITe_WinMenuItem miLease { get { return miView.Get<CUITe_WinMenuItem>("Name~Vehicle lease"); } }

        public CUITe_WinButton btnClear { get { return Get<CUITe_WinButton>("Name=Clear"); } }

        public CUITe_WinRadioButton rbDegrees { get { return Get<CUITe_WinRadioButton>("Name=Radians"); } }
        public CUITe_WinRadioButton rbRadians { get { return Get<CUITe_WinRadioButton>("Name=Degrees"); } }
        public CUITe_WinRadioButton rbGrads { get { return Get<CUITe_WinRadioButton>("Name=Grads"); } }

        public CUITe_WinButton btn0 { get { return Get<CUITe_WinButton>("Name=0"); } }
        public CUITe_WinButton btn1 { get { return Get<CUITe_WinButton>("Name=1"); } }
        public CUITe_WinButton btn2 { get { return Get<CUITe_WinButton>("Name=2"); } }
        public CUITe_WinButton btn3 { get { return Get<CUITe_WinButton>("Name=3"); } }
        public CUITe_WinButton btn4 { get { return Get<CUITe_WinButton>("Name=4"); } }
        public CUITe_WinButton btn5 { get { return Get<CUITe_WinButton>("Name=5"); } }
        public CUITe_WinButton btn6 { get { return Get<CUITe_WinButton>("Name=6"); } }
        public CUITe_WinButton btn7 { get { return Get<CUITe_WinButton>("Name=7"); } }
        public CUITe_WinButton btn8 { get { return Get<CUITe_WinButton>("Name=8"); } }
        public CUITe_WinButton btn9 { get { return Get<CUITe_WinButton>("Name=9"); } }
        public CUITe_WinButton btnAdd { get { return Get<CUITe_WinButton>("Name=Add"); } }
        public CUITe_WinButton btnSubtract { get { return Get<CUITe_WinButton>("Name=Subtract"); } }
        public CUITe_WinButton btnMultiply { get { return Get<CUITe_WinButton>("Name=Multiply"); } }
        public CUITe_WinButton btnDivide { get { return Get<CUITe_WinButton>("Name=Divide"); } }
        public CUITe_WinButton btnEquals { get { return Get<CUITe_WinButton>("Name=Equals"); } }

        public CUITe_WinText txtResult { get { return Get<CUITe_WinText>("Name=Result"); } }
    }
}
