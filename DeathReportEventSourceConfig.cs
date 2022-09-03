using Newtonsoft.Json.Linq;
using RainbowMage.OverlayPlugin;
using System;

namespace AmamaNagigi.DeathReportPlugin
{
    [Serializable]
    public class DeathReportEventSourceConfig
    {
        public string ExampleString = "Example String";
        public DeathReportEventSourceConfig()
        {

        }

        public static DeathReportEventSourceConfig LoadConfig(IPluginConfig pluginConfig)
        {
            var result = new DeathReportEventSourceConfig();
            if (pluginConfig.EventSourceConfigs.ContainsKey("DeathReportESConfig"))
            {
                var obj = pluginConfig.EventSourceConfigs["DeathReportESConfig"];

                if (obj.TryGetValue("ExampleString", out JToken value))
                {
                    result.ExampleString = value.ToString();
                }
            }
            return result;
        }

        public void SaveConfig(IPluginConfig pluginConfig)
        {
            pluginConfig.EventSourceConfigs["DeathReportESConfig"] = JObject.FromObject(this);
        }
    }
}
