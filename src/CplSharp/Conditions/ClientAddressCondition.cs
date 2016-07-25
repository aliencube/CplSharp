using System;
using System.Text.RegularExpressions;

namespace CplSharp.Conditions
{
    /// <summary>
    /// This represents the pre-defined condition entity for client address.
    /// </summary>
    public class ClientAddressCondition : Condition
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="ClientAddressCondition"/> class.
        /// </summary>
        /// <param name="value"></param>
        public ClientAddressCondition(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(nameof(value));
            }

            this.Value = value;

            this.Name = "client.address";
            this.ValidationPattern = new Regex($@"({ValidationPatterns.ValidationPatterns.IpV4Address}|{ValidationPatterns.ValidationPatterns.IpV4Subnet}|{ValidationPatterns.ValidationPatterns.AlphaNumeric})");
        }
    }
}
