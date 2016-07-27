using System;
using System.Text.RegularExpressions;

namespace CplSharp.Validations
{
    /// <summary>
    /// This specifies the validation pattern.
    /// </summary>
    public class ValidationPattern
    {
        /// <summary>
        /// Identifies the IPv4 address pattern.
        /// </summary>
        public static ValidationPattern IpV4Address = new ValidationPattern("IpV4Address") { Pattern = @"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$", Message = "Invalid IPv4 address format"};

        /// <summary>
        /// Identifies the IPv4 subnet pattern.
        /// </summary>
        public static ValidationPattern IpV4Subnet = new ValidationPattern("IpV4Subnet") { Pattern = @"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}/\d{1,2}$", Message = "Invalid IPv4 sbnet format" };

        /// <summary>
        /// Identifies the alphanumeric value pattern.
        /// </summary>
        public static ValidationPattern AlphaNumeric = new ValidationPattern("AlphaNumeric") { Pattern = @"^[\w\d\.]+$", Message = "Value must be alphabet, number, underscore or period" };

        private Regex _pattern;

        /// <summary>
        /// Initialises a new instance of the <see cref="ValidationPattern"/> class.
        /// </summary>
        /// <param name="name">Name of the validation pattern.</param>
        public ValidationPattern(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            this.Name = name;
        }

        /// <summary>
        /// Gets the pattern name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets or sets the validation pattern in regular-expression.
        /// </summary>
        public string Pattern
        {
            get { return this._pattern.ToString(); }
            set { this._pattern = new Regex(value); }
        }

        /// <summary>
        /// Gets or sets the message when validation fails.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Returns a string which represents the object instance.
        /// </summary>
        /// <param name="instance"><see cref="ValidationPattern"/> instance.</param>
        public static implicit operator string(ValidationPattern instance)
        {
            return instance.Name;
        }

        /// <summary>
        /// Returns a string which represents the object instance.
        /// </summary>
        /// <param name="instance"><see cref="ValidationPattern"/> instance.</param>
        public static implicit operator Regex(ValidationPattern instance)
        {
            return instance._pattern;
        }
    }
}
