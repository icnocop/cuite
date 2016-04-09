namespace CUITe.Browsers
{
    /// <summary>
    /// Web browser
    /// </summary>
    public class Browser : IBrowser
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Browser"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="windowClassName">Name of the window class.</param>
        public Browser(string name, string windowClassName)
            : this(name, name, windowClassName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Browser"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="processName">Name of the process.</param>
        /// <param name="windowClassName">Name of the window class.</param>
        /// <param name="dialogClassName">Name of the dialog class.</param>
        public Browser(string name, string processName, string windowClassName, string dialogClassName = null)
        {
            Name = name;
            ProcessName = processName;
            WindowClassName = windowClassName;
            DialogClassName = dialogClassName;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the process.
        /// </summary>
        /// <value>
        /// The name of the process.
        /// </value>
        public string ProcessName { get; set; }

        /// <summary>
        /// Gets or sets the name of the window class.
        /// </summary>
        /// <value>
        /// The name of the window class.
        /// </value>
        public string WindowClassName { get; set; }

        /// <summary>
        /// Gets or sets the name of the dialog class.
        /// </summary>
        /// <value>
        /// The name of the dialog class.
        /// </value>
        public string DialogClassName { get; set; }
    }
}