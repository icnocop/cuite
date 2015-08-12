using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfSlider
    /// </summary>
    public class WpfSlider : WpfControl<CUIT.WpfSlider>
    {
        public WpfSlider() : base() { }
        public WpfSlider(string searchParameters) : base(searchParameters) { }

        public double LargeChange
        {
            get { return this.UnWrap().LargeChange; }
        }

        public double MaximumPosition
        {
            get { return this.UnWrap().MaximumPosition; }
        }

        public double MinimumPosition
        {
            get { return this.UnWrap().MinimumPosition; }
        }

        public double Position
        {
            get { return this.UnWrap().Position; }
            set { this.UnWrap().Position = value; }
        }

        public string PositionAsString
        {
            get { return this.UnWrap().PositionAsString; }
            set { this.UnWrap().PositionAsString = value; }
        }

        public double SmallChange
        {
            get { return this.UnWrap().SmallChange; }
        }
    }
}