using System.Collections.Generic;
using System.Text;

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

        /// <summary>
        /// Converts the instance to serialised string.
        /// </summary>
        /// <returns>Returns the serialised string converted from the instance.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendLine($"define {this.LayerType} {this.DefinitionType} {this.Name}");
            foreach (var layer in this.Layers)
            {
                sb.AppendLine($"\t{layer}");
            }

            sb.AppendLine("end");
            sb.AppendLine();

            return sb.ToString();
        }
    }
}