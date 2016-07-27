namespace CplSharp.Validations
{
    /// <summary>
    /// This represents the entity containing validation error.
    /// </summary>
    public class ValidationError
    {
        /// <summary>
        /// Gets or sets the name of object/instance where validation error arose.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the validation error message.
        /// </summary>
        public string Message { get; set; }
    }
}