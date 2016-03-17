using System;
using CUITe.PageObjects;
using CUITe.ScreenObjects;

namespace CUITe.Workflows
{
    /// <summary>
    /// Class representing a user input workflow where the coded UI tests flow from a start view
    /// object to the end view object.
    /// </summary>
    /// <typeparam name="TStart">The type of view object where the workflow start.</typeparam>
    /// <typeparam name="TEnd">The type of view object where the workflow end.</typeparam>
    /// <remarks>
    /// Defining a user input workflow for a series of tasks that numerous coded UI tests execute
    /// improves test code maintainability. The workflow may never leave a view object, or may
    /// traverse numerous view objects and end up in a state where the actual test can commence.
    /// </remarks>
    /// <seealso cref="ViewObject"/>
    /// <seealso cref="Page"/>
    /// <seealso cref="PageObject"/>
    /// <seealso cref="PageObject{T}"/>
    /// <seealso cref="Screen"/>
    /// <seealso cref="ScreenObject"/>
    /// <seealso cref="ScreenObject{T}"/>
    public abstract class Workflow<TStart, TEnd>
        where TStart : ViewObject
        where TEnd : ViewObject
    {
        private readonly TStart start;

        /// <summary>
        /// Initializes a new instance of the <see cref="Workflow{TStart, TEnd}"/> class.
        /// </summary>
        /// <param name="start">The view object where the workflow start.</param>
        protected Workflow(TStart start)
        {
            if (start == null)
                throw new ArgumentNullException("start");

            this.start = start;
        }

        /// <summary>
        /// Steps through the workflow.
        /// </summary>
        /// <returns>The view object where the workflow end.</returns>
        public abstract TEnd StepThrough();

        /// <summary>
        /// Gets the view object where the workflow start.
        /// </summary>
        protected TStart Start
        {
            get { return start; }
        }
    }
}