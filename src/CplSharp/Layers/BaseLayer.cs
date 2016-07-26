using System.Collections.Generic;

using CplSharp.Actions;
using CplSharp.Conditions;
using CplSharp.Sections;

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
            this.Sections = new List<BaseSection>();
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
        /// Gets or sets the list of sections.
        /// </summary>
        public List<BaseSection> Sections { get; set; }

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
