namespace CUITe.Browsers
{
    /// <summary>
    /// Web browser
    /// </summary>
    public interface IBrowser
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the process.
        /// </summary>
        /// <value>
        /// The name of the process.
        /// </value>
        string ProcessName { get; set; }

        /// <summary>
        /// Gets or sets the name of the window class.
        /// </summary>
        /// <value>
        /// The name of the window class.
        /// </value>
        string WindowClassName { get; set; }

        /// <summary>
        /// Gets or sets the name of the dialog class.
        /// </summary>
        /// <value>
        /// The name of the dialog class.
        /// </value>
        string DialogClassName { get; set; }
    }
}