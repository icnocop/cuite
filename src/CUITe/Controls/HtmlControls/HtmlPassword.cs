using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlPassword : HtmlEdit
    {
        public HtmlPassword(string searchProperties = null)
            : this(new CUITControls.HtmlEdit(), searchProperties)
        {
        }

        public HtmlPassword(CUITControls.HtmlEdit sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
            AddSearchProperty(CUITControls.HtmlControl.PropertyNames.Type, "PASSWORD");
        }
    }
}