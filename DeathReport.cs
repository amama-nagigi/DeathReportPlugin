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
    public class DeathReport : IOverlayAddon
    {
        #region PluginSetting
        public string Name => "Death Report";

        public string Description => "Show death report.";

        public Type OverlayType => typeof(DeathReportOverlay);

        public Type OverlayConfigType => typeof(DeathReportOverlayConfig);

        public Type OverlayConfigControlType => typeof(DeathReportOverlayConfigPanel);

        public IOverlay CreateOverlayInstance(IOverlayConfig config)
        {
            return new DeathReportOverlay((DeathReportOverlayConfig)config);
        }

        public IOverlayConfig CreateOverlayConfigInstance(string name)
        {
            return new DeathReportOverlayConfig(name);
        }

        public Control CreateOverlayConfigControlInstance(IOverlay overlay)
        {
            return new DeathReportOverlayConfigPanel((DeathReportOverlay)overlay);
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
        public DeathReport()
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
