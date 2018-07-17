using AmamaNagigi.DeathReportPlugin.Entities;
using RainbowMage.OverlayPlugin;
using System;

namespace AmamaNagigi.DeathReportPlugin
{
    public class DeathReporterOverlayConfig : OverlayConfigBase
    {
        #region PluginSetting
        private DeathReporterOverlayConfig() : base(null) {
            Initialize();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name"></param>
        public DeathReporterOverlayConfig(string name) : base(name)
        {
            Initialize();
        }

        public override Type OverlayType => typeof(DeathReporterOverlay);
        #endregion

        /// <summary>
        /// HTMLに送るコンフィグ
        /// </summary>
        public AddonConfig AddonConfig { get; set; }

        /// <summary>
        /// 初期値の設定
        /// </summary>
        private void Initialize()
        {
            // デフォルト値の設定
            this.Url = GetDefaultUrl();

            this.AddonConfig = new AddonConfig();
            this.AddonConfig.SecBeforeDeath = 5;
            this.AddonConfig.MaxCount = 10;
            this.AddonConfig.IsExpanded = false;
            this.AddonConfig.ClearOnStart = true;
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
