using System;
using System.Collections.Generic;

using CplSharp.Actions;
using CplSharp.Conditions;
using CplSharp.Definitions;
using CplSharp.Layers;

namespace CplSharp.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dapac = new DefinitionAction() { Action = new ProxyPolicyDefinition("p_x0005") };
            var pac = new ProxyAddressCondition("p_x0002_Authentication_corpProxyIPs") { Action = dapac };

            var dacac1 = new DefinitionAction() { Action = new ProxyPolicyDefinition("SchollFiltering") };
            var cac1 = new ClientAddressCondition("schoolIpsWithPolicies") { Action = dacac1 };

            var dacac2 = new DefinitionAction() { Action = new ProxyPolicyDefinition("filterCheck") };
            var cac2 = new ClientAddressCondition("filterCheckServer") { Action = dacac2 };

            var conditions = new List<Condition>() { pac, cac1, cac2 };

            var action = new DefinitionAction() { Action = new ProxyPolicyDefinition("p_x0006") };

            var pl = new ProxyLayer() { Conditions = conditions, Action = action };

            var cp = new ContentPolicy() { Proxy = pl };

            Console.WriteLine(cp);
        }
    }
}
