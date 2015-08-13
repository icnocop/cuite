using Microsoft.VisualStudio.TestTools.UITest.Extension;
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
            this.SearchProperties[CUITControls.WinWindow.PropertyNames.Name] = "Windows Security";
            this.SearchProperties[CUITControls.WinWindow.PropertyNames.ClassName] = "#32770";
            this.TechnologyName = "MSAA";
            this.WindowTitles.Add("Windows Security");
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
        }

        internal CUITControls.WinText UIUseAnotherAccountText
        {
            get
            {
                if ((this.mUIUseanotheraccountText == null))
                {
                    this.mUIUseanotheraccountText = new CUITControls.WinText(this);
                    this.mUIUseanotheraccountText.SearchProperties[CUITControls.WinText.PropertyNames.Name] = "Use another account";
                    this.mUIUseanotheraccountText.TechnologyName = "MSAA";
                    this.mUIUseanotheraccountText.WindowTitles.Add("Windows Security");
                    this.mUIUseanotheraccountText.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                }
                return this.mUIUseanotheraccountText;
            }
        }

        internal CUITControls.WinEdit UIUsernameEdit
        {
            get
            {
                if ((this.mUIUsernameEdit == null))
                {
                    this.mUIUsernameEdit = new CUITControls.WinEdit(this);
                    this.mUIUsernameEdit.SearchProperties[CUITControls.WinEdit.PropertyNames.Name] = "User name";
                    this.mUIUsernameEdit.TechnologyName = "MSAA";
                    this.mUIUsernameEdit.WindowTitles.Add("Windows Security");
                    this.mUIUsernameEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                }
                return this.mUIUsernameEdit;
            }
        }

        internal CUITControls.WinEdit UIPasswordEdit
        {
            get
            {
                if ((this.mUIPasswordEdit == null))
                {
                    this.mUIPasswordEdit = new CUITControls.WinEdit(this);
                    this.mUIPasswordEdit.SearchProperties[CUITControls.WinEdit.PropertyNames.Name] = "Password";
                    this.mUIPasswordEdit.TechnologyName = "MSAA";
                    this.mUIPasswordEdit.WindowTitles.Add("Windows Security");
                    this.mUIPasswordEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                }
                return this.mUIPasswordEdit;
            }
        }

        internal CUITControls.WinButton UIOKButton
        {
            get
            {
                if ((this.mUIOKButton == null))
                {
                    this.mUIOKButton = new CUITControls.WinButton(this);
                    this.mUIOKButton.SearchProperties[CUITControls.WinButton.PropertyNames.Name] = "OK";
                    this.mUIOKButton.TechnologyName = "MSAA";
                    this.mUIOKButton.WindowTitles.Add("Windows Security");
                    this.mUIOKButton.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                }
                return this.mUIOKButton;
            }
        }
    }
}
