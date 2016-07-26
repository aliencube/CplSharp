using CplSharp.Enums;

namespace CplSharp.Definitions
{
    /// <summary>
    /// This specifies the definition type.
    /// </summary>
    public class DefinitionType : TypeSafeEnum
    {
        /// <summary>
        /// Identifies the action definition.
        /// </summary>
        public static DefinitionType Action = new DefinitionType("action", 1);

        /// <summary>
        /// Identifies the activ_content definition.
        /// </summary>
        public static DefinitionType ActiveContent = new DefinitionType("active_content", 2);

        /// <summary>
        /// Identifies the category definition.
        /// </summary>
        public static DefinitionType Category = new DefinitionType("category", 3);

        /// <summary>
        /// Identifies the condition definition.
        /// </summary>
        public static DefinitionType Condition = new DefinitionType("condition", 4);

        /// <summary>
        /// Identifies the javascript definition.
        /// </summary>
        public static DefinitionType JavaScript = new DefinitionType("javascript", 5);

        /// <summary>
        /// Identifies the policy definition.
        /// </summary>
        public static DefinitionType Policy = new DefinitionType("policy", 6);

        /// <summary>
        /// Identifies the server_url.domain condition definition.
        /// </summary>
        public static DefinitionType ServerUrlDomainCondition = new DefinitionType("server_url.domain condition", 7);

        /// <summary>
        /// Identifies the string definition.
        /// </summary>
        public static DefinitionType String = new DefinitionType("string", 8);

        /// <summary>
        /// Identifies the subnet definition.
        /// </summary>
        public static DefinitionType Subnet = new DefinitionType("subnet", 9);

        /// <summary>
        /// Identifies the url condition definition.
        /// </summary>
        public static DefinitionType UrlCondition = new DefinitionType("url condition", 10);

        /// <summary>
        /// Identifies the url.domain condition definition.
        /// </summary>
        public static DefinitionType UrlDomainCondition = new DefinitionType("url.domain condition", 11);

        /// <summary>
        /// Identifies the url_rewrite definition.
        /// </summary>
        public static DefinitionType UrlRewrite = new DefinitionType("url_rewrite", 12);

        /// <summary>
        /// Initialises a new instance of the <see cref="DefinitionType"/> class.
        /// </summary>
        /// <param name="name">Name of definition.</param>
        /// <param name="value">Value of definition.</param>
        public DefinitionType(string name, int value) : base (name, value)
        {
        }

        /// <summary>
        /// Returns a string which represents the object instance.
        /// </summary>
        /// <param name="instance"><see cref="DefinitionType"/> instance.</param>
        public static implicit operator string(DefinitionType instance)
        {
            return instance.ToString();
        }

        /// <summary>
        /// Returns a string which represents the object instance.
        /// </summary>
        /// <param name="instance"><see cref="DefinitionType"/> instance.</param>
        public static implicit operator int(DefinitionType instance)
        {
            return instance.Value;
        }
    }
}