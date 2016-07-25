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
        public ProxyPolicyDefinition()
        {
            this.LayerType = LayerType.Proxy;
            this.Layers = new List<BaseLayer>();
        }
    }
}