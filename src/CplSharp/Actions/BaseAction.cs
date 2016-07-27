using System;
using System.Collections.Generic;

using CplSharp.Validations;

namespace CplSharp.Actions
{
    /// <summary>
    /// This represents the base entity for the action to perform.
    /// </summary>
    public abstract class BaseAction : IValidator
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

        /// <summary>
        /// Validates the object model.
        /// </summary>
        /// <param name="errors">List of <see cref="ValidationError"/> instances.</param>
        /// <returns>Returns <c>True</c>, if successfully validated; otherwise returns <c>False</c>.</returns>
        public abstract bool Validate(out List<ValidationError> errors);
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
