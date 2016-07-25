namespace CplSharp.ValidationPatterns
{
    /// <summary>
    /// This represents the collection entity for validation patterns.
    /// </summary>
    public static class ValidationPatterns
    {
        /// <summary>
        /// Gets the IPV4 address pattern.
        /// </summary>
        public const string IpV4Address = @"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$";

        /// <summary>
        /// Gets the IPV4 address subnet pattern.
        /// </summary>
        public const string IpV4Subnet = @"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}/\d{1,2}$";

        /// <summary>
        /// Gets the alphe-numeric value pattern.
        /// </summary>
        public const string AlphaNumeric = @"[\w\d\.]+";
    }
}
