using System.Collections.Generic;
using System.Text;

using CplSharp.Actions;
using CplSharp.Exceptions;
using CplSharp.Extensions;

namespace CplSharp.Conditions
{
    /// <summary>
    /// This represents the condition entity.
    /// </summary>
    public class Condition
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="Condition"/> class.
        /// </summary>
        public Condition()
        {
            this.ConditionItems = new List<ConditionItem>();
        }

        /// <summary>
        /// Gets or sets the list of <see cref="ConditionItem"/> instances.
        /// </summary>
        public List<ConditionItem> ConditionItems { get; set; }

        /// <summary>
        /// Gets or sets the action to perform when the condition is true.
        /// </summary>
        public BaseAction Action { get; set; }

        /// <summary>
        /// Converts the current object instance to a string.
        /// </summary>
        /// <returns>Returns a string which represents the object instance.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();

            if (this.ConditionItems.IsNullOrEmpty())
            {
                throw new ConditionItemNotFoundException();
            }

            foreach (var item in this.ConditionItems)
            {
                sb.Append($"{item.Name}=\"{item.Value}\" ");
            }

            if (this.Action == null)
            {
                return sb.ToString().Trim();
            }

            sb.Append($"{this.Action}");

            return sb.ToString();
        }
    }
}
