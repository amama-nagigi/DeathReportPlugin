using RainbowMage.OverlayPlugin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AmamaNagigi.DeathReportPlugin
{
    public class DeathReporterOverlayConfig : OverlayConfigBase
    {
        #region PluginSetting
        private DeathReporterOverlayConfig() : base(null) { }

        public override Type OverlayType => typeof(DeathReporterOverlay);
        #endregion

        /// <summary>
        /// 直前何秒のログを吐くか
        /// </summary>
        public int SecBeforeDeath { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name"></param>
        public DeathReporterOverlayConfig(string name) : base(name)
        {
            // デフォルト値の設定
            this.Url = GetDefaultUrl();
            this.SecBeforeDeath = 5;
        }

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
