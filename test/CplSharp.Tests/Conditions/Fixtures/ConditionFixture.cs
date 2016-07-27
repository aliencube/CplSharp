using System;

using CplSharp.Conditions;

namespace CplSharp.Tests.Conditions.Fixtures
{
    /// <summary>
    /// This represents the fixture entity for the <see cref="ConditionTest"/> class.
    /// </summary>
    public class ConditionFixture : IDisposable
    {
        private bool _disposed;

        /// <summary>
        /// Initialises a new instance of the <see cref="ConditionFixture"/> class.
        /// </summary>
        public ConditionFixture()
        {
            this.Condition = new Condition();
        }

        /// <summary>
        /// Gets the <see cref="CplSharp.Conditions.Condition"/> instance.
        /// </summary>
        public Condition Condition { get; }

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
