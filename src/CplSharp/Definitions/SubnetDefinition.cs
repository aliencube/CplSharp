using System.Collections.Generic;
using System.Text;

namespace CplSharp.Definitions
{
    /// <summary>
    /// This represents the definition entity for subnet.
    /// </summary>
    public class SubnetDefinition : BaseDefinition
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="SubnetDefinition"/> class.
        /// </summary>
        /// <param name="name">Name of definition.</param>
        public SubnetDefinition(string name) : base(name)
        {
            this.DefinitionType = DefinitionType.Subnet;
            this.Values = new List<string>();
        }

        /// <summary>
        /// Gets or sets the list of subnets or IP addresses.
        /// </summary>
        public List<string> Values { get; set; }

        /// <summary>
        /// Converts the instance to serialised string.
        /// </summary>
        /// <returns>Returns the serialised string converted from the instance.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"define {this.DefinitionType} {this.Name}");

            foreach (var value in this.Values)
            {
                sb.AppendLine($"\t{value}");
            }

            sb.AppendLine("end");

            return sb.ToString();
        }
    }
}