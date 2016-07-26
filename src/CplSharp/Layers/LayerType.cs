using CplSharp.Enums;

namespace CplSharp.Layers
{
    /// <summary>
    /// This specifies the layer type.
    /// </summary>
    public class LayerType : TypeSafeEnum
    {
        /// <summary>
        /// Identifies the admin layer.
        /// </summary>
        public static LayerType Admin = new LayerType("Admin", 1);

        /// <summary>
        /// Identifies the cache layer.
        /// </summary>
        public static LayerType Cache = new LayerType("Cache", 2);

        /// <summary>
        /// Identifies the exception layer.
        /// </summary>
        public static LayerType Exception = new LayerType("Exception", 3);

        /// <summary>
        /// Identifies the forward layer.
        /// </summary>
        public static LayerType Forward = new LayerType("Forward", 4);

        /// <summary>
        /// Identifies the proxy layer.
        /// </summary>
        public static LayerType Proxy = new LayerType("Proxy", 5);

        /// <summary>
        /// Identifies the DNS proxy layer.
        /// </summary>
        public static LayerType DnxProxy = new LayerType("DNS-Proxy", 6);

        /// <summary>
        /// Identifies the SSL intercept layer.
        /// </summary>
        public static LayerType SslIntercept = new LayerType("SSL-Intercept", 7);

        /// <summary>
        /// Identifies the SSL layer.
        /// </summary>
        public static LayerType Ssl = new LayerType("SSL", 8);

        /// <summary>
        /// Initialises a new instance of the <see cref="LayerType"/> class.
        /// </summary>
        /// <param name="name">Name of definition.</param>
        /// <param name="value">Value of definition.</param>
        public LayerType(string name, int value) : base (name, value)
        {
        }

        /// <summary>
        /// Returns a string which represents the object instance.
        /// </summary>
        /// <param name="instance"><see cref="LayerType"/> instance.</param>
        public static implicit operator string(LayerType instance)
        {
            return instance.ToString();
        }

        /// <summary>
        /// Returns a string which represents the object instance.
        /// </summary>
        /// <param name="instance"><see cref="LayerType"/> instance.</param>
        public static implicit operator int(LayerType instance)
        {
            return instance.Value;
        }
    }
}