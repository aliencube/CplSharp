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
            sb.Append(this.RenderHeader());
            sb.Append(this.RenderSectionGuard());
            sb.Append(this.RenderConditions());
            sb.Append(this.RenderSectionAction());

            return sb.ToString();
        }

        private string RenderHeader()
        {
            var sb = new StringBuilder();
            sb.Append($"[{this.SectionType}]");

            return sb.ToString();
        }

        private string RenderSectionGuard()
        {
            var sb = new StringBuilder();

            if (this.SectionGuard == null)
            {
                sb.AppendLine();
                return sb.ToString();
            }

            sb.Append(" ");
            sb.AppendLine($"{this.SectionGuard}");

            return sb.ToString();
        }

        private string RenderConditions()
        {
            if (this.Conditions.IsNullOrEmpty())
            {
                return null;
            }

            var sb = new StringBuilder();
            foreach (var condition in this.Conditions)
            {
                sb.AppendLine($"\t{condition}");
            }

            return sb.ToString();
        }

        private string RenderSectionAction()
        {
            if (this.Action == null)
            {
                return null;
            }

            var sb = new StringBuilder();
            sb.AppendLine($"\t{this.Action}");

            return sb.ToString();
        }
    }
}