using Advanced_Combat_Tracker;
using RainbowMage.OverlayPlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmamaNagigi.DeathReportPlugin
{
    public class DeathReporter : IOverlayAddon
    {
        #region PluginSetting
        public string Name => "Death Report";

        public string Description => "Show death report.";

        public Type OverlayType => typeof(DeathReporterOverlay);

        public Type OverlayConfigType => typeof(DeathReporterOverlayConfig);

        public Type OverlayConfigControlType => typeof(DeathReporterOverlayConfigPanel);

        public IOverlay CreateOverlayInstance(IOverlayConfig config)
        {
            return new DeathReporterOverlay((DeathReporterOverlayConfig)config);
        }

        public IOverlayConfig CreateOverlayConfigInstance(string name)
        {
            return new DeathReporterOverlayConfig(name);
        }

        public Control CreateOverlayConfigControlInstance(IOverlay overlay)
        {
            return new DeathReporterOverlayConfigPanel((DeathReporterOverlay)overlay);
        }

        public void Dispose()
        {

        }
        #endregion

        public static string ResourceDirectory { get; set; }

        /// <summary>
        /// コンストラクタ
        /// (EnmityPluginよりコピーさせていただきました。)
        /// </summary>
        public DeathReporter()
        {
            Assembly asm = Assembly.GetCallingAssembly();
            if (asm.Location == null || asm.Location == "")
            {
                // 場所がわからないなら自分の場所にする
                asm = Assembly.GetExecutingAssembly();
            }
            ResourceDirectory = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(asm.Location), "resources");
        }
    }
}
