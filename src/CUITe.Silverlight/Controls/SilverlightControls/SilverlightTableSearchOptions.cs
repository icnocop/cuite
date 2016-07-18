namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Enum describing how cells are searched for in <see cref="SilverlightTable"/>.
    /// </summary>
    public enum SilverlightTableSearchOptions
    {
        /// <summary>
        /// The cell value should be equal to the value to search for.
        /// </summary>
        Normal,

        /// <summary>
        /// The trimmed cell value should be equal to the value to search for.
        /// </summary>
        NormalTight,

        /// <summary>
        /// The cell value should contain the value to search for.
        /// </summary>
        Greedy,

        /// <summary>
        /// The cell value should start with the value to search for.
        /// </summary>
        StartsWith,

        /// <summary>
        /// The cell value should end with the value to search for.
        /// </summary>
        EndsWith
    }
}
