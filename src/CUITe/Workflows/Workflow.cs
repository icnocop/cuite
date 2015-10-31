using System;
using CUITe.ObjectRepository;

namespace CUITe.Workflows
{
    /// <summary>
    /// Class representing a user input workflow where the coded UI tests flow from a start view
    /// components to the end view component.
    /// </summary>
    /// <typeparam name="TStart">The type of view component where the workflow start.</typeparam>
    /// <typeparam name="TEnd">The type of view component where the workflow end.</typeparam>
    /// <remarks>
    /// Defining a user input workflow for a series of tasks that numerous coded UI tests execute
    /// improves test code maintainability. The workflow may never leave a view component, or may
    /// traverse numerous view components and end up in a state where the actual test can commence.
    /// </remarks>
    /// <seealso cref="ViewComponent"/>
    /// <seealso cref="Page"/>
    /// <seealso cref="PageComponent"/>
    /// <seealso cref="PageComponent{T}"/>
    /// <seealso cref="Screen"/>
    /// <seealso cref="ScreenComponent"/>
    /// <seealso cref="ScreenComponent{T}"/>
    public abstract class Workflow<TStart, TEnd>
        where TStart : ViewComponent
        where TEnd : ViewComponent
    {
        private readonly TStart start;

        /// <summary>
        /// Initializes a new instance of the <see cref="Workflow{TStart, TEnd}"/> class.
        /// </summary>
        /// <param name="start">The view component where the workflow start.</param>
        protected Workflow(TStart start)
        {
            if (start == null)
                throw new ArgumentNullException("start");

            this.start = start;
        }

        /// <summary>
        /// Steps through the workflow.
        /// </summary>
        /// <returns>The view component where the workflow end.</returns>
        public abstract TEnd StepThrough();

        /// <summary>
        /// Gets the view component where the workflow start.
        /// </summary>
        protected TStart Start
        {
            get { return start; }
        }
    }
}