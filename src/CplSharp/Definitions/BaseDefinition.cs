namespace CplSharp.Definitions
{
    /// <summary>
    /// This represents the base definition entity. This MUST be inherited.
    /// </summary>
    public abstract class BaseDefinition
    {
        /// <summary>
        /// Gets or sets the name of the definition.
        /// </summary>
        public string Name { get; set; }
    }
}
