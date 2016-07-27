using System.Collections.Generic;

namespace CplSharp.Validations
{
    /// <summary>
    /// This provides interfaces for validation.
    /// </summary>
    public interface IValidator
    {
        /// <summary>
        /// Validates the object model.
        /// </summary>
        /// <param name="errors">List of <see cref="ValidationError"/> instances.</param>
        /// <returns>Returns <c>True</c>, if successfully validated; otherwise returns <c>False</c>.</returns>
        bool Validate(out List<ValidationError> errors);
    }
}
