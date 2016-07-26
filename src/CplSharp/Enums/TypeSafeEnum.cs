using System;

namespace CplSharp.Enums
{
    /// <summary>
    /// This represents the entity for enum value. This MUST be inherited.
    /// </summary>
    public abstract class TypeSafeEnum
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="TypeSafeEnum"/> class.
        /// </summary>
        /// <param name="name">Enum name.</param>
        /// <param name="value">Enum value.</param>
        protected TypeSafeEnum(string name, int value)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// Gets the enum name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the enum value.
        /// </summary>
        public int Value { get; }

        /// <summary>
        /// Converts the instance to serialised string.
        /// </summary>
        /// <returns>Returns the serialised string converted from the instance.</returns>
        public override string ToString()
        {
            return this.Name;
        }
    }
}
