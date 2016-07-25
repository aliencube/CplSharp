namespace CplSharp.Layers
{
    /// <summary>
    /// This specifies the layer type.
    /// </summary>
    public enum LayerType
    {
        /// <summary>
        /// Identifies no layer type is defined.
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// Identifies the admin layer.
        /// </summary>
        Admin = 1,

        /// <summary>
        /// Identifies the cache layer.
        /// </summary>
        Cache = 2,

        /// <summary>
        /// Identifies the exception layer.
        /// </summary>
        Exception = 3,

        /// <summary>
        /// Identifies the forward layer.
        /// </summary>
        Forward = 4,

        /// <summary>
        /// Identifies the proxy layer.
        /// </summary>
        Proxy = 5,

        /// <summary>
        /// Identifies the DNS proxy layer.
        /// </summary>
        DnxProxy = 6,

        /// <summary>
        /// Identifies the SSL intercept layer.
        /// </summary>
        SslIntercept = 7,

        /// <summary>
        /// Identifies the SSL layer.
        /// </summary>
        Ssl = 8,
    }
}