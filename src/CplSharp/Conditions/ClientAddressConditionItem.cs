using CplSharp.Definitions;

namespace CplSharp.Conditions
{
    /// <summary>
    /// This represents the pre-defined condition entity for client address.
    /// </summary>
    public class ClientAddressConditionItem : ConditionItem
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="ClientAddressConditionItem"/> class.
        /// </summary>
        /// <param name="value">Value of condition.</param>
        public ClientAddressConditionItem(string value) : base ("client.address", value)
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="ClientAddressConditionItem"/> class.
        /// </summary>
        /// <param name="definition">Instance inheriting <see cref="BaseDefinition"/>.</param>
        public ClientAddressConditionItem(BaseDefinition definition) : this(definition.Name)
        {
        }
    }
}
