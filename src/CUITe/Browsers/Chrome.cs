namespace CUITe.Browsers
{
    /// <summary>
    /// Chrome web browser
    /// </summary>
    public class Chrome : Browser, IBrowser
    {
        /// <summary>
        /// The name
        /// </summary>
        public new const string Name = "chrome";

        /// <summary>
        /// Initializes a new instance of the <see cref="Chrome"/> class.
        /// </summary>
        public Chrome()
            : base(Name, "Chrome_WidgetWin_1")
        {
        }
    }
}