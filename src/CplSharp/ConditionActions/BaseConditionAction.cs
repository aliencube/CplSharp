using System;

namespace CplSharp.ConditionActions
{
    /// <summary>
    /// This represents the base entity for the condition action to perform when the condition is true.
    /// </summary>
    public abstract class BaseConditionAction
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="BaseConditionAction"/> class.
        /// </summary>
        /// <param name="type">Type of action.</param>
        protected BaseConditionAction(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            this.Type = type;
        }

        /// <summary>
        /// Gets or sets the action to be performed.
        /// </summary>
        public object Action { get; set; }

        /// <summary>
        /// Type of action.
        /// </summary>
        protected Type Type { get; }

        /// <summary>
        /// <see cref="ConditionActionType"/> value.
        /// </summary>
        protected ConditionActionType ActionType { get; set; }
    }

    /// <summary>
    /// This represents the base entity for the condition action to perform when the condition is true.
    /// </summary>
    /// <typeparam name="T">Type of action.</typeparam>
    public abstract class BaseConditionAction<T> : BaseConditionAction where T : class
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="BaseConditionAction{T}"/> class.
        /// </summary>
        protected BaseConditionAction() : base(typeof(T))
        {
        }

        /// <summary>
        /// Gets or sets the action to be performed.
        /// </summary>
        public new T Action
        {
            get { return (T) Convert.ChangeType(base.Action, typeof(T)); }
            set { base.Action = value; }
        }
    }
}
