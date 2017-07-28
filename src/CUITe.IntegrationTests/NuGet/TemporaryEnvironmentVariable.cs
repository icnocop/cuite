using System;

namespace CUITe.IntegrationTests.NuGet
{
    /// <summary>
    /// Temporary Environment Variable
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public class TemporaryEnvironmentVariable : IDisposable
    {
        private string value;

        private readonly string variable;

        private readonly string oldValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="TemporaryEnvironmentVariable"/> class.
        /// </summary>
        /// <param name="variable">The variable.</param>
        /// <param name="value">The value.</param>
        public TemporaryEnvironmentVariable(string variable, string value)
        {
            this.variable = variable;
            this.value = value;

            this.oldValue = Environment.GetEnvironmentVariable(variable);

            Environment.SetEnvironmentVariable(variable, value);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Environment.SetEnvironmentVariable(this.variable, this.oldValue);
        }
    }
}
