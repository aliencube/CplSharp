using System.Collections.Generic;

using CplSharp.Actions;
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
        /// Initialises a new instance of the <see cref="BaseLayer"/> class.
        /// </summary>
        /// <param name="comment">Layer comment value.</param>
        protected BaseLayer(string comment = null)
        {
            this.Comment = comment;
            this.Conditions = new List<Condition>();
            this.Rules = new List<BaseRule>();
        }

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
        /// Gets or sets the action to perform at the last.
        /// </summary>
        public BaseAction Action { get; set; }

        /// <summary>
        /// Gets or sets the layer type.
        /// </summary>
        protected LayerType LayerType { get; set; }
    }
}
