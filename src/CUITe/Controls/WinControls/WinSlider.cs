using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinSlider
    /// </summary>
    public class WinSlider : WinControl<CUITControls.WinSlider>
    {
        public WinSlider() { }
        public WinSlider(string searchParameters) : base(searchParameters) { }

        public double LineSize
        {
            get { return UnWrap().LineSize; }
        }

        public double MaximumPosition
        {
            get { return UnWrap().MaximumPosition; }
        }

        public double MinimumPosition
        {
            get { return UnWrap().MinimumPosition; }
        }

        public double PageSize
        {
            get { return UnWrap().PageSize; }
        }

        public double Position
        {
            get { return UnWrap().Position; }
            set { UnWrap().Position = value; }
        }

        public string PositionAsString
        {
            get { return UnWrap().PositionAsString; }
            set { UnWrap().PositionAsString = value; }
        }

        public double TickCount
        {
            get { return UnWrap().TickCount; }
        }

        public double TickPosition
        {
            get { return UnWrap().TickPosition; }
        }

        public double TickValue
        {
            get { return UnWrap().TickValue; }
        }
    }
}