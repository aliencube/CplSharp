using CplSharp.Definitions;

namespace CplSharp.Conditions
{
    /// <summary>
    /// This represents the pre-defined condition entity for proxy address.
    /// </summary>
    public class ProxyAddressConditionItem : ConditionItem
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="ProxyAddressConditionItem"/> class.
        /// </summary>
        /// <param name="value">Value of condition.</param>
        public ProxyAddressConditionItem(string value) : base ("proxy.address", value)
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="ProxyAddressConditionItem"/> class.
        /// </summary>
        /// <param name="definition">Instance inheriting <see cref="BaseDefinition"/>.</param>
        public ProxyAddressConditionItem(BaseDefinition definition) : this(definition.Name)
        {
        }
    }
}
