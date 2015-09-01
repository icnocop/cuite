﻿using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlListItem : HtmlCustom
    {
        public HtmlListItem(string searchProperties = null)
            : this(new CUITControls.HtmlCustom(), searchProperties)
        {
        }

        public HtmlListItem(CUITControls.HtmlCustom sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}