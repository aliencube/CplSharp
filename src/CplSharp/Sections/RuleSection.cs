using System.Collections.Generic;
using System.Text;

using CplSharp.Conditions;
using CplSharp.Extensions;

namespace CplSharp.Sections
{
    /// <summary>
    /// This represents the section entity for rule.
    /// </summary>
    public class RuleSection : BaseSection
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="RuleSection"/> class.
        /// </summary>
        public RuleSection()
        {
            this.SectionType = SectionType.Rule;
            this.Conditions = new List<Condition>();
        }

        /// <summary>
        /// Converts the instance to serialised string.
        /// </summary>
        /// <returns>Returns the serialised string converted from the instance.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"[{this.SectionType}]");

            if (this.Conditions.IsNullOrEmpty())
            {
                return sb.ToString();
            }

            foreach (var condition in this.Conditions)
            {
                sb.AppendLine($"\t{condition}");
            }

            return sb.ToString();
        }
    }
}