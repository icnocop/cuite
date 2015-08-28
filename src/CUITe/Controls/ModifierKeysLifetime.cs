using System;
using System.Windows.Input;

namespace CUITe.Controls
{
    /// <summary>
    /// Class simplifying the concept of pressing and releasing modifier keys when it comes to
    /// keyboard input.
    /// </summary>
    internal class ModifierKeysLifetime : IDisposable
    {
        private readonly ControlBase controlBase;
        private readonly ModifierKeys keys;

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifierKeysLifetime"/> class.
        /// </summary>
        /// <param name="controlBase">The control in which to hold modifier keys.</param>
        /// <param name="keys">
        /// The sum of one or more values of the <see cref="ModifierKeys"/> enumeration.
        /// </param>
        public ModifierKeysLifetime(ControlBase controlBase, ModifierKeys keys)
        {
            if (controlBase == null)
                throw new ArgumentNullException("controlBase");

            this.controlBase = controlBase;
            this.keys = keys;

            controlBase.PressModifierKeys(keys);
        }

        /// <summary>
        /// Releases the pressed modifier keys.
        /// </summary>
        public void Dispose()
        {
            controlBase.ReleaseModifierKeys(keys);
        }
    }
}