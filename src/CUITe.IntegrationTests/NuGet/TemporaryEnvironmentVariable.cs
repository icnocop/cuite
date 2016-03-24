using System;

namespace CUITe.IntegrationTests.NuGet
{
    public class TemporaryEnvironmentVariable : IDisposable
    {
        private string value;

        private readonly string variable;

        private readonly string oldValue;

        public TemporaryEnvironmentVariable(string variable, string value)
        {
            this.variable = variable;
            this.value = value;

            this.oldValue = Environment.GetEnvironmentVariable(variable);

            Environment.SetEnvironmentVariable(variable, value);
        }

        public void Dispose()
        {
            Environment.SetEnvironmentVariable(this.variable, this.oldValue);
        }
    }
}
