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

            sb.Append(this.RenderHeader());
            sb.Append(this.RenderLayerGuard());
            sb.Append(this.RenderConditions());
            sb.Append(this.RenderSections());
            sb.Append(this.RenderLayerAction());

            return sb.ToString();
        }

        private string RenderHeader()
        {
            var sb = new StringBuilder();
            sb.Append($"<{this.LayerType}");

            if (!string.IsNullOrWhiteSpace(this.Comment))
            {
                sb.Append($" \"{this.Comment}\"");
            }

            sb.Append(">");

            return sb.ToString();
        }

        private string RenderLayerGuard()
        {
            var sb = new StringBuilder();

            if (this.LayerGuard == null)
            {
                sb.AppendLine();
                return sb.ToString();
            }

            sb.Append(" ");
            sb.AppendLine($"{this.LayerGuard}");

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

        private string RenderSections()
        {
            if (this.Sections.IsNullOrEmpty())
            {
                return null;
            }

            var sb =new StringBuilder();
            foreach (var section in this.Sections)
            {
                sb.AppendLine($"\t{section}");
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