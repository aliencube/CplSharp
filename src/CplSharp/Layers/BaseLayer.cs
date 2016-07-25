using System.Collections.Generic;

using CplSharp.Conditions;
using CplSharp.Rules;

namespace CplSharp.Layers
{
    /// <summary>
    /// This represents the base layer entity. This MUST be inherited.
    /// </summary>
    public abstract class BaseLayer
    {
        /// <summary>
        /// Gets or sets the comment of the layer.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the list of conditions.
        /// </summary>
        public List<Condition> Conditions { get; set; }

        /// <summary>
        /// Gets or sets the list of rules.
        /// </summary>
        public List<BaseRule> Rules { get; set; }

        /// <summary>
        /// Gets or sets the layer type.
        /// </summary>
        protected LayerType LayerType { get; set; }
    }
}
