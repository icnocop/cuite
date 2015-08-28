using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Input;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.Controls
{
    public abstract class ControlBase
    {
        private readonly UITestControl sourceControl;

        protected ControlBase(UITestControl sourceControl)
        {
            if (sourceControl == null)
                throw new ArgumentNullException("sourceControl");

            this.sourceControl = sourceControl;
        }

        /// <summary>
        /// Wraps WaitForControlReady method and Enabled property for a UITestControl.
        /// </summary>
        public bool Enabled
        {
            get
            {
                WaitForControlReady();
                return sourceControl.Enabled;
            }
        }

        /// <summary>
        /// Wraps the Exists property for a UITestControl.
        /// </summary>
        public bool Exists
        {
            get
            {
                if (sourceControl == null)
                {
                    return false;
                }

                return sourceControl.Exists;
            }
        }

        /// <summary>
        /// Get the Coded UI base type that is being wrapped by CUITe
        /// </summary>
        /// <returns></returns>
        public Type SourceType
        {
            get { return sourceControl.GetType(); }
        }

        public virtual ControlBase Parent
        {
            get { return null; }
        }

        public virtual ControlBase PreviousSibling
        {
            get { return null; }
        }

        public virtual ControlBase NextSibling
        {
            get { return null; }
        }

        public virtual ControlBase FirstChild
        {
            get { return null; }
        }

        public UITestControl SourceControl
        {
            get { return sourceControl; }
        }

        public virtual List<ControlBase> GetChildren()
        {
            return null;
        }

        /// <summary>
        /// Wraps the WaitForControlReady method for a UITestControl.
        /// </summary>
        public void WaitForControlReady()
        {
            sourceControl.WaitForControlReady();
        }

        /// <summary>
        /// Wraps WaitForControlReady and SetFocus methods for a UITestControl.
        /// </summary>
        public void SetFocus()
        {
            WaitForControlReady();
            sourceControl.SetFocus();
        }

        /// <summary>
        /// Waits for the control to be ready and then clicks the specified mouse button.
        /// </summary>
        /// <param name="button">
        /// The <see cref="MouseButtons"/> that will be used for clicking.
        /// </param>
        public void Click(MouseButtons button = MouseButtons.Left)
        {
            WaitForControlReady();
            Mouse.Click(sourceControl, button);
        }

        /// <summary>
        /// Waits for the control to be ready and then clicks the default mouse button while
        /// holding the specified modifier keys.
        /// </summary>
        /// <param name="modifierKeys">
        /// <see cref="ModifierKeys"/> to be pressed while clicking.
        /// </param>
        public void Click(ModifierKeys modifierKeys)
        {
            WaitForControlReady();
            Mouse.Click(sourceControl, modifierKeys);
        }

        /// <summary>
        /// Waits for the control to be ready and then double-clicks the specified mouse button.
        /// </summary>
        /// <param name="button">
        /// The <see cref="MouseButtons"/> that will be used for double-clicking.
        /// </param>
        public void DoubleClick(MouseButtons button = MouseButtons.Left)
        {
            WaitForControlReady();
            Mouse.DoubleClick(sourceControl, button);
        }

        /// <summary>
        /// Waits for the control to be ready and then double-clicks the default mouse button while
        /// holding the specified modifier keys.
        /// </summary>
        /// <param name="modifierKeys">
        /// <see cref="ModifierKeys"/> that will be used for double-clicking.
        /// </param>
        public void DoubleClick(ModifierKeys modifierKeys)
        {
            WaitForControlReady();
            Mouse.DoubleClick(sourceControl, modifierKeys);
        }

        /// <summary>
        /// Waits for the control to be ready and then presses the specified modifier keys without
        /// releasing them.
        /// </summary>
        /// <param name="keys">
        /// The sum of one or more values of the <see cref="ModifierKeys"/> enumeration.
        /// </param>
        /// <remarks>
        /// Modifier keys that have been pressed must be explicitly released by using the
        /// <see cref="ReleaseModifierKeys"/>.
        /// </remarks>
        public void PressModifierKeys(ModifierKeys keys)
        {
            WaitForControlReady();
            Keyboard.PressModifierKeys(sourceControl, keys);
        }

        /// <summary>
        /// Waits for the control to be ready and then releases the specified keys that were
        /// previously pressed by using the <see cref="PressModifierKeys"/> method.
        /// </summary>
        /// <param name="keys">
        /// The sum of one or more values of the <see cref="ModifierKeys"/> enumeration.
        /// </param>
        public void ReleaseModifierKeys(ModifierKeys keys)
        {
            WaitForControlReady();
            Keyboard.ReleaseModifierKeys(sourceControl, keys);
        }

        /// <summary>
        /// Waits for the control to be ready and then holds the specified modifier keys until
        /// the returned instance is disposed.
        /// </summary>
        /// <param name="keys">
        /// The sum of one or more values of the <see cref="ModifierKeys"/> enumeration.
        /// </param>
        /// <returns>
        /// An instance that releases the modifier keys when disposed.
        /// </returns>
        /// <remarks>
        /// This method is an alternative to using <see cref="PressModifierKeys"/> and
        /// <see cref="ReleaseModifierKeys"/>.
        /// </remarks>
        public IDisposable HoldModifierKeys(ModifierKeys keys)
        {
            WaitForControlReady();
            return new ModifierKeysLifetime(this, keys);
        }

        /// <summary>
        /// Waits for the control to be ready and then sends keystrokes to generate the specified
        /// text string.
        /// </summary>
        /// <param name="text">The text for which to generate keystrokes.</param>
        /// <param name="modifierKeys">
        /// The sum of one or more values of the <see cref="ModifierKeys"/> enumeration.
        /// </param>
        /// <param name="isEncoded">true if the text is encoded; otherwise, false.</param>
        /// <param name="isUnicode">true if the text is Unicode text; otherwise, false.</param>
        /// <remarks>
        /// The string may contain key modifiers.
        /// 
        /// Control     ^
        /// Shift       +
        /// Alt         %
        /// Windows     #
        /// 
        /// To send a Control+A keyboard sequence, use <code>SendKeys("^a")</code>.
        /// 
        /// To send a character that represents a key modifier, enclose the character in a pair of
        /// braces. For example, to send a plus sign, use <code>SendKeys("{+}")</code>.
        /// 
        /// To send a brace, enclose the brace in a pair of braces. For example, to send an opening
        /// or closing brace, use <code>SendKeys("{{}")</code> or <code>SendKeys("{}}")</code>,
        /// respectively.
        /// </remarks>
        public void SendKeys(
            string text,
            ModifierKeys modifierKeys = ModifierKeys.None,
            bool isEncoded = false,
            bool isUnicode = true)
        {
            WaitForControlReady();
            Keyboard.SendKeys(sourceControl, text, modifierKeys, isEncoded, isUnicode);
        }
    }
}