using System.Collections.Generic;

using CplSharp.Conditions;

namespace CplSharp.Sections
{
    /// <summary>
    /// This represents the base entity for section. This MUST be inherited.
    /// </summary>
    public abstract class BaseSection
    {
        /// <summary>
        /// Gets or sets the section type.
        /// </summary>
        protected SectionType SectionType { get; set; }

        /// <summary>
        /// Gets or sets the list of conditions.
        /// </summary>
        public List<Condition> Conditions { get; set; }
    }
}
