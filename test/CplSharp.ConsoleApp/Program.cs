using System;
using System.Collections.Generic;

using CplSharp.Actions;
using CplSharp.Conditions;
using CplSharp.Definitions;
using CplSharp.Layers;
using CplSharp.Sections;

namespace CplSharp.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var defsnpac = new SubnetDefinition("p_x0002_Authentication_corpProxyIPs")
                            {
                                Values =
                                {
                                    "10.1.100.67",
                                    "10.1.100.74"
                                }
                            };
            var plpac1 = new ProxyLayer()
                         {
                             Action =
                                 new DefinitionAction()
                                 {
                                     Value = new ProxyPolicyDefinition("p_x0003")
                                 }
                         };
            var defpppac = new ProxyPolicyDefinition("p_x0005") { Layers = { plpac1 } };
            var dapac = new DefinitionAction() { Value = defpppac };
            var paci = new ProxyAddressConditionItem(defsnpac);
            var pac = new Condition() { ConditionItems = { paci }, Action = dapac };

            var defsncac1 = new SubnetDefinition("schoolIpsWithPolicies")
                          {
                              Values =
                              {
                                  "10.101.88.0/21",
                                  "10.47.240.0/21"
                              }
                          };
            var dacac1 = new DefinitionAction() { Value = new ProxyPolicyDefinition("SchollFiltering") };
            var caci1 = new ClientAddressConditionItem(defsncac1);
            var cac1 = new Condition() { ConditionItems = { caci1 }, Action = dacac1 };

            var defsncac2 = new SubnetDefinition("filterCheckServer")
                          {
                              Values =
                              {
                                  "10.250.7.65",
                                  "1.1.1.0/29"
                              }
                          };
            var dacac2 = new DefinitionAction() { Value = new ProxyPolicyDefinition("filterCheck") };
            var caci2 = new ClientAddressConditionItem(defsncac2);
            var cac2 = new Condition() { ConditionItems = { caci2 }, Action = dacac2 };

            var conditions = new List<Condition>() { pac, cac1, cac2 };

            var action = new DefinitionAction() { Value = new ProxyPolicyDefinition("p_x0006") };

            var pl = new ProxyLayer() { Conditions = conditions, Action = action };

            var sectionGuard = new Condition() { ConditionItems = { new ClientAddressConditionItem("10.3.0.0/18") } };
            var condition = new Condition()
                            {
                                ConditionItems = { new ClientAddressConditionItem("10.3.0.0/21") },
                                Action = new DefinitionAction() { Value = new ProxyPolicyDefinition("p_6052") }
                            };
            var section = new RuleSection() { SectionGuard = sectionGuard, Conditions = { condition } };

            var layerGuard = new Condition() { ConditionItems = { new ClientAddressConditionItem("10.2.0.0/15") } };
            var proxy = new ProxyLayer() { LayerGuard = layerGuard, Sections = { section } };
            var def = new ProxyPolicyDefinition("Net_10.0.0.0_12") { Layers = { proxy } };

            var definitions = new List<BaseDefinition>() { def, defsnpac, defsncac1, defsncac2, defpppac };

            var cp = new ContentPolicy() { Proxy = pl, Definitions = definitions };

            Console.WriteLine(cp);
        }
    }
}
