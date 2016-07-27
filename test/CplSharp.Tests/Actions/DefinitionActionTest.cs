using System.Collections.Generic;
using System.Linq;

using CplSharp.Actions;
using CplSharp.Definitions;
using CplSharp.Tests.Actions.Fixtures;
using CplSharp.Validations;

using FluentAssertions;

using Xunit;

namespace CplSharp.Tests.Actions
{
    /// <summary>
    /// This represents the test entity for the <see cref="DefinitionAction"/> class.
    /// </summary>
    public class DefinitionActionTest : IClassFixture<DefinitionActionFixture>
    {
        private readonly DefinitionAction _action;

        /// <summary>
        /// Initialises a new instance of the <see cref="DefinitionActionTest"/> class.
        /// </summary>
        /// <param name="fixture"><see cref="DefinitionActionFixture"/> instance.</param>
        public DefinitionActionTest(DefinitionActionFixture fixture)
        {
            this._action = fixture.DefinitionAction;
        }

        /// <summary>
        /// Tests whether the method should return <c>True</c> or not.
        /// </summary>
        /// <param name="name">Name of definition.</param>
        [Theory]
        [InlineData("abc_123")]
        public void Given_Definition_Validate_ShouldReturn_True(string name)
        {
            var value = new ProxyPolicyDefinition(name);
            this._action.Value = value;

            List<ValidationError> errors;
            var result = this._action.Validate(out errors);

            result.Should().BeTrue();
            errors.Should().BeNullOrEmpty();
        }

        /// <summary>
        /// Tests whether the method should return <c>False</c> or not.
        /// </summary>
        /// <param name="name">Name of definition.</param>
        [Theory]
        [InlineData("abc-123")]
        [InlineData("abc#123")]
        public void Given_Definition_Validate_ShouldReturn_False(string name)
        {
            var value = new ProxyPolicyDefinition(name);
            this._action.Value = value;

            List<ValidationError> errors;
            var result = this._action.Validate(out errors);

            result.Should().BeFalse();
            errors.Should().HaveCount(1);

            var error = errors.First();
            error.Name.Should().BeEquivalentTo(name);
            error.Message.Should().BeEquivalentTo(ValidationPattern.AlphaNumeric.Message);
        }

        /// <summary>
        /// Tests whether the method should serialise the instance properly or not.
        /// </summary>
        /// <param name="name"></param>
        [Theory]
        [InlineData("abc_123")]
        public void Given_Definition_Instance_ShouldBe_Serialised(string name)
        {
            var value = new ProxyPolicyDefinition(name);
            this._action.Value = value;

            var expected = $"{value.DefinitionType}.{value.Name}";

            var result = this._action.ToString();
            result.Should().BeEquivalentTo(expected);
        }
    }
}
