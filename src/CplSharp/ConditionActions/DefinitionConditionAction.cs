using CplSharp.Definitions;

namespace CplSharp.ConditionActions
{
    /// <summary>
    /// This represents the condition action entity for definition.
    /// </summary>
    public class DefinitionConditionAction : BaseConditionAction<BaseDefinition>
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="DefinitionConditionAction"/> class.
        /// </summary>
        public DefinitionConditionAction()
        {
            this.ActionType = ConditionActionType.Definition;
        }
    }
}