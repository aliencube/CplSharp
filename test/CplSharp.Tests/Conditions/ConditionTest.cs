using CplSharp.Conditions;
using CplSharp.Tests.Conditions.Fixtures;

using Xunit;

namespace CplSharp.Tests.Conditions
{
    /// <summary>
    /// This represents the test entity for the <see cref="Condition"/> class.
    /// </summary>
    public class ConditionTest : IClassFixture<ConditionFixture>
    {
        private readonly Condition _condition;

        /// <summary>
        /// Initialises a new instance of the <see cref="ConditionTest"/> class.
        /// </summary>
        /// <param name="fixture"><see cref="ConditionFixture"/> instance.</param>
        public ConditionTest(ConditionFixture fixture)
        {
            this._condition = fixture.Condition;
        }
    }
}
