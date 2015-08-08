namespace CUITe.Browsers
{
    public class Chrome : Browser, IBrowser
    {
        public static string Name = "chrome";

        public Chrome()
            : base(Name, "Chrome_WidgetWin_1")
        {
        }
    }
}
