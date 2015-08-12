using System;

namespace CUITe.Controls
{
    /// <summary>
    /// Factory class for creating CUITe objects
    /// </summary>
    public class ControlBaseFactory
    {
        public static T Create<T>(string searchProperties)
            where T : IControlBase
        {
            return (T)Activator.CreateInstance(typeof(T), new object[] { searchProperties });
        }
    }
}