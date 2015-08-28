using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfSlider
    /// </summary>
    public class WpfSlider : WpfControl<CUITControls.WpfSlider>
    {
        public WpfSlider(CUITControls.WpfSlider sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfSlider(), searchProperties)
        {
        }

        public double LargeChange
        {
            get { return SourceControl.LargeChange; }
        }

        public double MaximumPosition
        {
            get { return SourceControl.MaximumPosition; }
        }

        public double MinimumPosition
        {
            get { return SourceControl.MinimumPosition; }
        }

        public double Position
        {
            get { return SourceControl.Position; }
            set { SourceControl.Position = value; }
        }

        public string PositionAsString
        {
            get { return SourceControl.PositionAsString; }
            set { SourceControl.PositionAsString = value; }
        }

        public double SmallChange
        {
            get { return SourceControl.SmallChange; }
        }
    }
}