using System;
using System.Text.RegularExpressions;

namespace CplSharp.Conditions
{
    /// <summary>
    /// This represents the pre-defined condition entity for proxy address.
    /// </summary>
    public class ProxyAddressCondition : Condition
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="ProxyAddressCondition"/> class.
        /// </summary>
        /// <param name="value"></param>
        public ProxyAddressCondition(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(nameof(value));
            }

            this.Value = value;

            this.Name = "proxy.address";
            this.ValidationPattern = new Regex($@"({ValidationPatterns.ValidationPatterns.IpV4Address}|{ValidationPatterns.ValidationPatterns.IpV4Subnet}|{ValidationPatterns.ValidationPatterns.AlphaNumeric})");
        }
    }
}
