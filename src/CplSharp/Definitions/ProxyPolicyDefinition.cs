using System.Collections.Generic;

using CplSharp.Layers;

namespace CplSharp.Definitions
{
    /// <summary>
    /// This represents the definition entity for proxy policy.
    /// </summary>
    public class ProxyPolicyDefinition : PolicyDefinition
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="ProxyPolicyDefinition"/> class.
        /// </summary>
        /// <param name="name">Name of definition.</param>
        public ProxyPolicyDefinition(string name) : base(name)
        {
            this.LayerType = LayerType.Proxy;
            this.Layers = new List<BaseLayer>();
        }
    }
}