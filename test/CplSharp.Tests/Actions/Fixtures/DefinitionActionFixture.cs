using System;

using CplSharp.Actions;

namespace CplSharp.Tests.Actions.Fixtures
{
    /// <summary>
    /// This represents the fixture entity for the <see cref="DefinitionActionTest"/> class.
    /// </summary>
    public class DefinitionActionFixture : IDisposable
    {
        private bool _disposed;

        /// <summary>
        /// Initialises a new instance of the <see cref="DefinitionActionFixture"/> class.
        /// </summary>
        public DefinitionActionFixture()
        {
            this.DefinitionAction = new DefinitionAction();
        }

        /// <summary>
        /// Gets the <see cref="DefinitionAction"/> instance.
        /// </summary>
        public DefinitionAction DefinitionAction { get; }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (this._disposed)
            {
                return;
            }

            this._disposed = true;
        }
    }
}
