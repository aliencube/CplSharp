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
        /// Initialises a new instance of the <see cref="PolicyDefinition"/> class.
        /// </summary>
        /// <param name="name">Name of definition.</param>
        protected PolicyDefinition(string name) : base(name)
        {
            this.DefinitionType = DefinitionType.Policy;
        }

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