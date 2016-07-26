using CplSharp.Definitions;

namespace CplSharp.Conditions
{
    /// <summary>
    /// This represents the entity for condition used in the <see cref="Condition"/> class.
    /// </summary>
    public class ConditionItem
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="ConditionItem"/> class.
        /// </summary>
        /// <param name="name">Name of condition.</param>
        /// <param name="value">Value of condition.</param>
        public ConditionItem(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="ConditionItem"/> class.
        /// </summary>
        /// <param name="name">Name of condition.</param>
        /// <param name="definition">Instance inheriting <see cref="BaseDefinition"/>.</param>
        public ConditionItem(string name, BaseDefinition definition) : this(name, definition.Name)
        {
        }

        /// <summary>
        /// Gets or sets the condition name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the condition value.
        /// </summary>
        public string Value { get; set; }
    }
}