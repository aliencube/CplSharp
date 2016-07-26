using CplSharp.Definitions;

namespace CplSharp.Actions
{
    /// <summary>
    /// This represents the action entity for definition.
    /// </summary>
    public class DefinitionAction : BaseAction<BaseDefinition>
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="DefinitionAction"/> class.
        /// </summary>
        public DefinitionAction()
        {
            this.ActionType = ActionType.Definition;
        }

        /// <summary>
        /// Returns a string which represents the object instance.
        /// </summary>
        /// <param name="instance"><see cref="DefinitionAction"/> instance.</param>
        public static implicit operator string(DefinitionAction instance)
        {
            return instance.ToString();
        }

        /// <summary>
        /// Converts the instance to serialised string.
        /// </summary>
        /// <returns>Returns the serialised string converted from the instance.</returns>
        public override string ToString()
        {
            return $"{this.Action.DefinitionType.ToString().ToLowerInvariant()}.{this.Action.Name}";
        }
    }
}