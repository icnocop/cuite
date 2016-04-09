namespace CUITe.Browsers
{
    /// <summary>
    /// Firefox web browser
    /// </summary>
    public class Firefox : Browser, IBrowser
    {
        /// <summary>
        /// The name
        /// </summary>
        public new const string Name = "firefox";

        /// <summary>
        /// Initializes a new instance of the <see cref="Firefox"/> class.
        /// </summary>
        public Firefox()
            : base(Name, "MozillaWindowClass")
        {
        }
    }
}