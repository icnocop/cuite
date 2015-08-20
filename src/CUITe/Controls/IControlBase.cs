 using System;
 using System.Collections.Generic;
 using System.Windows.Forms;
 using System.Windows.Input;

namespace CUITe.Controls
{
    public interface IControlBase
    {
        IControlBase Parent { get; }

        IControlBase PreviousSibling { get; }

        IControlBase NextSibling { get; }

        IControlBase FirstChild { get; }

        bool Enabled { get; }

        bool Exists { get; }

        Type SourceType { get; }

        void Wrap(object control);

        void WrapReady(object control);

        void WaitForControlReady();

        /// <summary>
        /// Waits for the control to be ready and then clicks the specified mouse button.
        /// </summary>
        /// <param name="button">
        /// The <see cref="MouseButtons"/> that will be used for clicking.
        /// </param>
        void Click(MouseButtons button = MouseButtons.Left);

        /// <summary>
        /// Waits for the control to be ready and then clicks the default mouse button while
        /// holding the specified modifier keys.
        /// </summary>
        /// <param name="modifierKeys">
        /// <see cref="ModifierKeys"/> to be pressed while clicking.
        /// </param>
        void Click(ModifierKeys modifierKeys);

        /// <summary>
        /// Waits for the control to be ready and then double-clicks the specified mouse button.
        /// </summary>
        /// <param name="button">
        /// The <see cref="MouseButtons"/> that will be used for double-clicking.
        /// </param>
        void DoubleClick(MouseButtons button = MouseButtons.Left);

        /// <summary>
        /// Waits for the control to be ready and then double-clicks the default mouse button while
        /// holding the specified modifier keys.
        /// </summary>
        /// <param name="modifierKeys">
        /// <see cref="ModifierKeys"/> that will be used for double-clicking.
        /// </param>
        void DoubleClick(ModifierKeys modifierKeys);

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
        void PressModifierKeys(ModifierKeys keys);

        /// <summary>
        /// Waits for the control to be ready and then releases the specified keys that were
        /// previously pressed by using the <see cref="PressModifierKeys"/> method.
        /// </summary>
        /// <param name="keys">
        /// The sum of one or more values of the <see cref="ModifierKeys"/> enumeration.
        /// </param>
        void ReleaseModifierKeys(ModifierKeys keys);

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
        void SendKeys(
            string text,
            ModifierKeys modifierKeys = ModifierKeys.None,
            bool isEncoded = false,
            bool isUnicode = true);
        
        void SetFocus();

        void SetSearchProperty(string sPropertyName, string sValue);

        void SetSearchPropertyRegx(string sPropertyName, string sValue);

        List<IControlBase> GetChildren();
    }
}