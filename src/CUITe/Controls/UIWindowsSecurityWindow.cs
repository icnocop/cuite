using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls
{
    internal class UIWindowsSecurityWindow : CUITControls.WinWindow
    {
        private CUITControls.WinText mUIUseanotheraccountText;
        private CUITControls.WinEdit mUIUsernameEdit;
        private CUITControls.WinEdit mUIPasswordEdit;
        private CUITControls.WinButton mUIOKButton;

        internal UIWindowsSecurityWindow()
        {
            SearchProperties[UITestControl.PropertyNames.Name] = "Windows Security";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            TechnologyName = "MSAA";
            WindowTitles.Add("Windows Security");
            SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
        }

        internal CUITControls.WinText UIUseAnotherAccountText
        {
            get
            {
                if ((mUIUseanotheraccountText == null))
                {
                    mUIUseanotheraccountText = new CUITControls.WinText(this);
                    mUIUseanotheraccountText.SearchProperties[UITestControl.PropertyNames.Name] = "Use another account";
                    mUIUseanotheraccountText.TechnologyName = "MSAA";
                    mUIUseanotheraccountText.WindowTitles.Add("Windows Security");
                    mUIUseanotheraccountText.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                }
                return mUIUseanotheraccountText;
            }
        }

        internal CUITControls.WinEdit UIUsernameEdit
        {
            get
            {
                if ((mUIUsernameEdit == null))
                {
                    mUIUsernameEdit = new CUITControls.WinEdit(this);
                    mUIUsernameEdit.SearchProperties[UITestControl.PropertyNames.Name] = "User name";
                    mUIUsernameEdit.TechnologyName = "MSAA";
                    mUIUsernameEdit.WindowTitles.Add("Windows Security");
                    mUIUsernameEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                }
                return mUIUsernameEdit;
            }
        }

        internal CUITControls.WinEdit UIPasswordEdit
        {
            get
            {
                if ((mUIPasswordEdit == null))
                {
                    mUIPasswordEdit = new CUITControls.WinEdit(this);
                    mUIPasswordEdit.SearchProperties[UITestControl.PropertyNames.Name] = "Password";
                    mUIPasswordEdit.TechnologyName = "MSAA";
                    mUIPasswordEdit.WindowTitles.Add("Windows Security");
                    mUIPasswordEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                }
                return mUIPasswordEdit;
            }
        }

        internal CUITControls.WinButton UIOKButton
        {
            get
            {
                if ((mUIOKButton == null))
                {
                    mUIOKButton = new CUITControls.WinButton(this);
                    mUIOKButton.SearchProperties[UITestControl.PropertyNames.Name] = "OK";
                    mUIOKButton.TechnologyName = "MSAA";
                    mUIOKButton.WindowTitles.Add("Windows Security");
                    mUIOKButton.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                }
                return mUIOKButton;
            }
        }
    }
}