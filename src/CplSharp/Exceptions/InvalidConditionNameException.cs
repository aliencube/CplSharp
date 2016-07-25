using System;

#if NET461
using System.Runtime.Serialization;
#endif

#if !NET461
using ApplicationException = System.InvalidOperationException;
#endif

namespace CplSharp.Exceptions
{
    /// <summary>
    /// This represents the exception entity thrown when the condition name is invalid.
    /// </summary>
    public class InvalidConditionNameException : ApplicationException
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="InvalidConditionNameException"/> class.
        /// </summary>
        public InvalidConditionNameException()
            : this("Condition name invalid")
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="InvalidConditionNameException"/> class.
        /// </summary>
        /// <param name="message">A message that describes the error. </param>
        public InvalidConditionNameException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="InvalidConditionNameException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception. </param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception. </param>
        public InvalidConditionNameException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

#if NET461
        /// <summary>
        /// Initialises a new instance of the <see cref="InvalidConditionNameException"/> class.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data. </param>
        /// <param name="context">The contextual information about the source or destination. </param>
        protected InvalidConditionNameException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }
}