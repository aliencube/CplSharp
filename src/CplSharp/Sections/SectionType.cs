using CplSharp.Enums;

namespace CplSharp.Sections
{
    /// <summary>
    /// This specifies the section type.
    /// </summary>
    public class SectionType : TypeSafeEnum
    {
        /// <summary>
        /// Identifies the Rule section.
        /// </summary>
        public static SectionType Rule = new SectionType("Rule", 1);

        /// <summary>
        /// Identifies the url section.
        /// </summary>
        public static SectionType Url = new SectionType("url", 2);

        /// <summary>
        /// Identifies the url.domain section.
        /// </summary>
        public static SectionType UrlDomain = new SectionType("url.domain", 2);
        
        /// <summary>
        /// Identifies the server_url.domain section.
        /// </summary>
        public static SectionType ServerUrlDomain = new SectionType("server_url.domain", 2);

        /// <summary>
        /// Initialises a new instance of the <see cref="SectionType"/> class.
        /// </summary>
        /// <param name="name">Name of section.</param>
        /// <param name="value">Value of section.</param>
        public SectionType(string name, int value) : base(name, value)
        {
        }

        /// <summary>
        /// Returns a string which represents the object instance.
        /// </summary>
        /// <param name="instance"><see cref="SectionType"/> instance.</param>
        public static implicit operator string(SectionType instance)
        {
            return instance.ToString();
        }

        /// <summary>
        /// Returns a string which represents the object instance.
        /// </summary>
        /// <param name="instance"><see cref="SectionType"/> instance.</param>
        public static implicit operator int(SectionType instance)
        {
            return instance.Value;
        }
    }
}