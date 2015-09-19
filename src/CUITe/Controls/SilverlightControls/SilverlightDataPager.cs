﻿#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents a data pages control to test the user interface (UI) of a Silverlight
    /// application.
    /// </summary>
    public class SilverlightDataPager : SilverlightControl<CUITControls.SilverlightDataPager>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightDataPager"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightDataPager(By searchConfiguration = null)
            : this(new CUITControls.SilverlightDataPager(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightDataPager"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightDataPager(CUITControls.SilverlightDataPager sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}
#endif