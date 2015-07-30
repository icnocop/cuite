using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls
{
    internal class UIWindowsSecurityWindow : WinWindow
    {
        private WinText mUIUseanotheraccountText;
        private WinEdit mUIUsernameEdit;
        private WinEdit mUIPasswordEdit;
        private WinButton mUIOKButton;

        internal UIWindowsSecurityWindow()
        {
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Windows Security";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.TechnologyName = "MSAA";
            this.WindowTitles.Add("Windows Security");
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
        }

        internal WinText UIUseAnotherAccountText
        {
            get
            {
                if ((this.mUIUseanotheraccountText == null))
                {
                    this.mUIUseanotheraccountText = new WinText(this);
                    this.mUIUseanotheraccountText.SearchProperties[WinText.PropertyNames.Name] = "Use another account";
                    this.mUIUseanotheraccountText.TechnologyName = "MSAA";
                    this.mUIUseanotheraccountText.WindowTitles.Add("Windows Security");
                    this.mUIUseanotheraccountText.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                }
                return this.mUIUseanotheraccountText;
            }
        }

        internal WinEdit UIUsernameEdit
        {
            get
            {
                if ((this.mUIUsernameEdit == null))
                {
                    this.mUIUsernameEdit = new WinEdit(this);
                    this.mUIUsernameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "User name";
                    this.mUIUsernameEdit.TechnologyName = "MSAA";
                    this.mUIUsernameEdit.WindowTitles.Add("Windows Security");
                    this.mUIUsernameEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                }
                return this.mUIUsernameEdit;
            }
        }

        internal WinEdit UIPasswordEdit
        {
            get
            {
                if ((this.mUIPasswordEdit == null))
                {
                    this.mUIPasswordEdit = new WinEdit(this);
                    this.mUIPasswordEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Password";
                    this.mUIPasswordEdit.TechnologyName = "MSAA";
                    this.mUIPasswordEdit.WindowTitles.Add("Windows Security");
                    this.mUIPasswordEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                }
                return this.mUIPasswordEdit;
            }
        }

        internal WinButton UIOKButton
        {
            get
            {
                if ((this.mUIOKButton == null))
                {
                    this.mUIOKButton = new WinButton(this);
                    this.mUIOKButton.SearchProperties[WinButton.PropertyNames.Name] = "OK";
                    this.mUIOKButton.TechnologyName = "MSAA";
                    this.mUIOKButton.WindowTitles.Add("Windows Security");
                    this.mUIOKButton.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                }
                return this.mUIOKButton;
            }
        }
    }
}
