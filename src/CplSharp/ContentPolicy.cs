using System.Collections.Generic;
using System.Text;

using CplSharp.Definitions;
using CplSharp.Extensions;
using CplSharp.Layers;

namespace CplSharp
{
    /// <summary>
    /// This represents the entity for the content policy.
    /// </summary>
    public class ContentPolicy
    {
        /// <summary>
        /// Gets or sets the <see cref="ProxyLayer"/> instance that rules globally.
        /// </summary>
        public ProxyLayer Proxy { get; set; }

        /// <summary>
        /// Gets or sets the list of definitions of the content policy.
        /// </summary>
        public List<BaseDefinition> Definitions { get; set; }

        /// <summary>
        /// Returns a string which represents the object instance.
        /// </summary>
        /// <param name="instance"><see cref="ContentPolicy"/> instance.</param>
        public static implicit operator string(ContentPolicy instance)
        {
            return instance.ToString();
        }

        /// <summary>
        /// Converts the instance to serialised string.
        /// </summary>
        /// <returns>Returns the serialised string converted from the instance.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();

            if (this.Proxy != null)
            {
                sb.AppendLine($"{this.Proxy}");
            }

            if (this.Definitions.IsNullOrEmpty())
            {
                return sb.ToString();
            }

            foreach (var definition in this.Definitions)
            {
                sb.AppendLine($"{definition}");
            }

            return sb.ToString();
        }
    }
}