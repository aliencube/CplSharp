using System.Text;

using CplSharp.Extensions;

namespace CplSharp.Layers
{
    /// <summary>
    /// This represents the layer entity for proxy.
    /// </summary>
    public class ProxyLayer : BaseLayer
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="ProxyLayer"/> class.
        /// </summary>
        /// <param name="comment">Layer comment value.</param>
        public ProxyLayer(string comment = null) : base(comment)
        {
            this.LayerType = LayerType.Proxy;
        }

        /// <summary>
        /// Converts the instance to serialised string.
        /// </summary>
        /// <returns>Returns the serialised string converted from the instance.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine();
            sb.Append(this.RenderTag());
            sb.Append(this.RenderConditions());
            sb.Append(this.RenderRules());
            sb.Append(this.RenderLayerAction());
            sb.AppendLine();

            return sb.ToString();
        }

        private string RenderTag()
        {
            var sb = new StringBuilder();
            sb.Append($"<{this.LayerType}");
            if (!string.IsNullOrWhiteSpace(this.Comment))
            {
                sb.Append($" \"{this.Comment}\"");
            }
            sb.AppendLine(">");

            return sb.ToString();
        }

        private string RenderConditions()
        {
            if (this.Conditions.IsNullOrEmpty())
            {
                return null;
            }

            var sb = new StringBuilder();
            foreach (var condition in this.Conditions)
            {
                sb.AppendLine($"\t{condition}");
            }

            return sb.ToString();
        }

        private string RenderRules()
        {
            if (this.Rules.IsNullOrEmpty())
            {
                return null;
            }

            var sb =new StringBuilder();
            foreach (var rule in this.Rules)
            {
                sb.AppendLine($"\t{rule}");
            }

            return sb.ToString();
        }

        private string RenderLayerAction()
        {
            if (this.Action == null)
            {
                return null;
            }

            var sb = new StringBuilder();
            sb.AppendLine($"\t{this.Action}");

            return sb.ToString();
        }
    }
}