using System.Collections.Generic;
using System.Text.RegularExpressions;

using CplSharp.Definitions;
using CplSharp.Validations;

namespace CplSharp.Actions
{
    /// <summary>
    /// This represents the action entity for definition.
    /// </summary>
    public class DefinitionAction : BaseAction<BaseDefinition>
    {
        private readonly Regex _definitionName;

        /// <summary>
        /// Initialises a new instance of the <see cref="DefinitionAction"/> class.
        /// </summary>
        public DefinitionAction()
        {
            this.ActionType = ActionType.Definition;

            this._definitionName = ValidationPattern.AlphaNumeric;
        }

        /// <summary>
        /// Validates the object model.
        /// </summary>
        /// <param name="errors">List of <see cref="ValidationError"/> instances.</param>
        /// <returns>Returns <c>True</c>, if successfully validated; otherwise returns <c>False</c>.</returns>
        public override bool Validate(out List<ValidationError> errors)
        {
            errors = null;

            if (this.Value == null)
            {
                return true;
            }

            if (this._definitionName.IsMatch(this.Value.Name))
            {
                return true;
            }

            var error = new ValidationError()
                        {
                            Name = this.Value.Name,
                            Message = ValidationPattern.AlphaNumeric.Message,
                        };

            errors = new List<ValidationError>() { error };
            return false;
        }

        /// <summary>
        /// Converts the instance to serialised string.
        /// </summary>
        /// <returns>Returns the serialised string converted from the instance.</returns>
        public override string ToString()
        {
            return $"{this.Value.DefinitionType}.{this.Value.Name}";
        }
    }
}