using System.Text;
using System.Text.RegularExpressions;
using CplSharp.Actions;
using CplSharp.Definitions;
using CplSharp.Exceptions;

namespace CplSharp.Conditions
{
    /// <summary>
    /// This represents the condition entity.
    /// </summary>
    public class Condition
    {
        private readonly Regex _namePattern;

        /// <summary>
        /// Initialises a new instance of the <see cref="Condition"/> class.
        /// </summary>
        public Condition()
        {
            this._namePattern = new Regex(ValidationPatterns.ValidationPatterns.AlphaNumeric);
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="Condition"/> class.
        /// </summary>
        /// <param name="validationPattern">String value for validation.</param>
        public Condition(string validationPattern) : this()
        {
            if (string.IsNullOrWhiteSpace(validationPattern))
            {
                return;
            }

            this.ValidationPattern = new Regex(validationPattern);
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="Condition"/> class.
        /// </summary>
        /// <param name="validationPattern"><see cref="Regex"/> instance for the validation.</param>
        public Condition(Regex validationPattern) : this()
        {
            this.ValidationPattern = validationPattern;
        }

        /// <summary>
        /// Gets or sets the condition name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the condition value.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the action to perform when the condition is true.
        /// </summary>
        public BaseAction Action { get; set; }

        /// <summary>
        /// Gets or sets the validation pattern for value.
        /// </summary>
        public Regex ValidationPattern { get; set; }

        /// <summary>
        /// Returns a string which represents the object instance.
        /// </summary>
        /// <param name="condition"><see cref="Condition"/> instance.</param>
        public static implicit operator string(Condition condition)
        {
            return condition.ToString();
        }

        /// <summary>
        /// Converts the current object instance to a string.
        /// </summary>
        /// <returns>Returns a string which represents the object instance.</returns>
        public override string ToString()
        {
            if (!this._namePattern.IsMatch(this.Name))
            {
                throw new InvalidConditionNameException();
            }

            if (this.ValidationPattern == null)
            {
                throw new ValidationPatternNotFoundException();
            }

            if (!this.ValidationPattern.IsMatch(this.Value))
            {
                throw new InvalidConditionValueException();
            }

            var sb = new StringBuilder();
            sb.Append($"{this.Name.ToLowerInvariant()}=\"{this.Value}\"");

            if (this.Action == null)
            {
                return sb.ToString();
            }

            sb.Append($" {this.Action}");
            return sb.ToString();
        }
    }
}
