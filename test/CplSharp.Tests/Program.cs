using CplSharp.Tests.Actions;
using CplSharp.Tests.Actions.Fixtures;

namespace CplSharp.Tests
{
    /// <summary>
    /// This represents the main entry point for debugging unit tests.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Performs debugging unit testing.
        /// </summary>
        /// <param name="args">List of arguments.</param>
        public static void Main(string[] args)
        {
            // Create test instance and run a test method you want to debug
            // with a break point.
            var fixture = new DefinitionActionFixture();
            var test = new DefinitionActionTest(fixture);

            test.Given_Definition_Validate_ShouldReturn_False("abc-123");
        }
    }
}
