 using System;
 using System.Windows.Forms;

namespace CUITe.Controls
{
    public interface IControlBase
    {
        IControlBase FirstChild { get; }

        Type SourceType { get; }

        void Wrap(object control);

        void WrapReady(object control);

        /// <summary>
        /// Waits for the control to be ready and then clicks the specified mouse button.
        /// </summary>
        /// <param name="button">
        /// The <see cref="MouseButtons"/> that will be used for clicking.
        /// </param>
        void Click(MouseButtons button = MouseButtons.Left);
    }
}