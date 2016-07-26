namespace CplSharp.Definitions
{
    /// <summary>
    /// This represents the base definition entity. This MUST be inherited.
    /// </summary>
    public abstract class BaseDefinition
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="BaseDefinition"/> class.
        /// </summary>
        /// <param name="name">Name of definition.</param>
        protected BaseDefinition(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets the name of the definition.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the definition type.
        /// </summary>
        public DefinitionType DefinitionType { get; set; }
    }
}
