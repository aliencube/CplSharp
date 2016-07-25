using System.Collections.Generic;

using CplSharp.Layers;

namespace CplSharp.Definitions
{
    /// <summary>
    /// This represents the definition entity for policy.
    /// </summary>
    public abstract class PolicyDefinition : BaseDefinition
    {
        /// <summary>
        /// Gets or sets the layer type.
        /// </summary>
        public LayerType LayerType { get; set; }

        /// <summary>
        /// Gets or sets the list of layers. All layers MUST be of the same layer types as the definition is.
        /// </summary>
        public List<BaseLayer> Layers { get; set; }
    }
}