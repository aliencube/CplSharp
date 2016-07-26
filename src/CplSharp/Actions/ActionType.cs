using CplSharp.Enums;

namespace CplSharp.Actions
{
    /// <summary>
    /// This specifies the action type.
    /// </summary>
    public class ActionType : TypeSafeEnum
    {
        /// <summary>
        /// Identifies the definition is performed.
        /// </summary>
        public static ActionType Definition = new ActionType("definition", 1);

        /// <summary>
        /// Initialises a new instance of the <see cref="ActionType"/> class.
        /// </summary>
        /// <param name="name">Name of definition.</param>
        /// <param name="value">Value of definition.</param>
        public ActionType(string name, int value) : base(name, value)
        {
        }

        /// <summary>
        /// Returns a string which represents the object instance.
        /// </summary>
        /// <param name="instance"><see cref="ActionType"/> instance.</param>
        public static implicit operator string(ActionType instance)
        {
            return instance.ToString();
        }

        /// <summary>
        /// Returns a string which represents the object instance.
        /// </summary>
        /// <param name="instance"><see cref="ActionType"/> instance.</param>
        public static implicit operator int(ActionType instance)
        {
            return instance.Value;
        }
    }
}