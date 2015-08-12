using Microsoft.VisualStudio.TestTools.UITest.Extension;
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls
{
    internal class UIWindowsSecurityWindow : CUIT.WinWindow
    {
        private CUIT.WinText mUIUseanotheraccountText;
        private CUIT.WinEdit mUIUsernameEdit;
        private CUIT.WinEdit mUIPasswordEdit;
        private CUIT.WinButton mUIOKButton;

        internal UIWindowsSecurityWindow()
        {
            this.SearchProperties[CUIT.WinWindow.PropertyNames.Name] = "Windows Security";
            this.SearchProperties[CUIT.WinWindow.PropertyNames.ClassName] = "#32770";
            this.TechnologyName = "MSAA";
            this.WindowTitles.Add("Windows Security");
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
        }

        internal CUIT.WinText UIUseAnotherAccountText
        {
            get
            {
                if ((this.mUIUseanotheraccountText == null))
                {
                    this.mUIUseanotheraccountText = new CUIT.WinText(this);
                    this.mUIUseanotheraccountText.SearchProperties[CUIT.WinText.PropertyNames.Name] = "Use another account";
                    this.mUIUseanotheraccountText.TechnologyName = "MSAA";
                    this.mUIUseanotheraccountText.WindowTitles.Add("Windows Security");
                    this.mUIUseanotheraccountText.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                }
                return this.mUIUseanotheraccountText;
            }
        }

        internal CUIT.WinEdit UIUsernameEdit
        {
            get
            {
                if ((this.mUIUsernameEdit == null))
                {
                    this.mUIUsernameEdit = new CUIT.WinEdit(this);
                    this.mUIUsernameEdit.SearchProperties[CUIT.WinEdit.PropertyNames.Name] = "User name";
                    this.mUIUsernameEdit.TechnologyName = "MSAA";
                    this.mUIUsernameEdit.WindowTitles.Add("Windows Security");
                    this.mUIUsernameEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                }
                return this.mUIUsernameEdit;
            }
        }

        internal CUIT.WinEdit UIPasswordEdit
        {
            get
            {
                if ((this.mUIPasswordEdit == null))
                {
                    this.mUIPasswordEdit = new CUIT.WinEdit(this);
                    this.mUIPasswordEdit.SearchProperties[CUIT.WinEdit.PropertyNames.Name] = "Password";
                    this.mUIPasswordEdit.TechnologyName = "MSAA";
                    this.mUIPasswordEdit.WindowTitles.Add("Windows Security");
                    this.mUIPasswordEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                }
                return this.mUIPasswordEdit;
            }
        }

        internal CUIT.WinButton UIOKButton
        {
            get
            {
                if ((this.mUIOKButton == null))
                {
                    this.mUIOKButton = new CUIT.WinButton(this);
                    this.mUIOKButton.SearchProperties[CUIT.WinButton.PropertyNames.Name] = "OK";
                    this.mUIOKButton.TechnologyName = "MSAA";
                    this.mUIOKButton.WindowTitles.Add("Windows Security");
                    this.mUIOKButton.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                }
                return this.mUIOKButton;
            }
        }
    }
}
