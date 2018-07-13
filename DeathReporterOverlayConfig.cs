using RainbowMage.OverlayPlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AmamaNagigi.DeathReportPlugin
{
    public class DeathReporterOverlayConfig : OverlayConfigBase
    {
        /// <summary>
        /// 直前何秒のログを吐くか
        /// </summary>
        public int SecBeforeDeath { get; set; }

        public DeathReporterOverlayConfig(string name) : base(name)
        {
            // デフォルト値の設定
            this.Url = GetDefaultUrl();
            this.SecBeforeDeath = 5;
        }

        private DeathReporterOverlayConfig() : base(null) { }

        public override Type OverlayType => typeof(DeathReporterOverlay);

        /// <summary>
        /// HTMLパスの初期値を取得
        /// </summary>
        /// <returns></returns>
        private string GetDefaultUrl()
        {
            return new Uri(System.IO.Path.Combine(DeathReporter.ResourceDirectory, "deathreport.html")).ToString();
        }
    }
}
