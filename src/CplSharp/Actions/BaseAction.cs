using System;

namespace CplSharp.Actions
{
    /// <summary>
    /// This represents the base entity for the action to perform.
    /// </summary>
    public abstract class BaseAction
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="BaseAction"/> class.
        /// </summary>
        /// <param name="type">Type of action.</param>
        protected BaseAction(Type type)
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
        public object Value { get; set; }

        /// <summary>
        /// Type of action.
        /// </summary>
        protected Type Type { get; }

        /// <summary>
        /// <see cref="Actions.ActionType"/> value.
        /// </summary>
        protected ActionType ActionType { get; set; }
    }

    /// <summary>
    /// This represents the base entity for the action to perform.
    /// </summary>
    /// <typeparam name="T">Type of action.</typeparam>
    public abstract class BaseAction<T> : BaseAction where T : class
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="BaseAction{T}"/> class.
        /// </summary>
        protected BaseAction() : base(typeof(T))
        {
        }

        /// <summary>
        /// Gets or sets the action to be performed.
        /// </summary>
        public new T Value
        {
            get { return (T)base.Value; }
            set { base.Value = value; }
        }
    }
}
