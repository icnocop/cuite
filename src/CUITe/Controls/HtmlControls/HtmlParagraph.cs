﻿using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlParagraph : HtmlCustom
    {
        private const string TagName = "p";

        public HtmlParagraph(string searchProperties = null)
            : this(new CUITControls.HtmlCustom(), searchProperties)
        {
        }

        public HtmlParagraph(CUITControls.HtmlCustom sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
            AddSearchProperty(CUITControls.HtmlControl.PropertyNames.TagName, TagName);
        }
    }
}