using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfSlider
    /// </summary>
    public class WpfSlider : WpfControl<CUITControls.WpfSlider>
    {
        public WpfSlider()
        {
        }

        public WpfSlider(string searchParameters)
            : base(searchParameters)
        {
        }

        public double LargeChange
        {
            get { return UnWrap().LargeChange; }
        }

        public double MaximumPosition
        {
            get { return UnWrap().MaximumPosition; }
        }

        public double MinimumPosition
        {
            get { return UnWrap().MinimumPosition; }
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

        public double SmallChange
        {
            get { return UnWrap().SmallChange; }
        }
    }
}