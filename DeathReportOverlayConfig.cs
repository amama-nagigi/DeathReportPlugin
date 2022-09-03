using AmamaNagigi.DeathReportPlugin.Entities;
using RainbowMage.OverlayPlugin;
using System;

namespace AmamaNagigi.DeathReportPlugin
{
    public class DeathReportOverlayConfig : OverlayConfigBase
    {
        #region PluginSetting
        private DeathReportOverlayConfig() : base(null) {
            Initialize();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name"></param>
        public DeathReportOverlayConfig(string name) : base(name)
        {
            Initialize();
        }

        public override Type OverlayType => typeof(DeathReportOverlay);
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
            return "https://amama-nagigi.github.io/DeathReportPlugin/overlay/";
        }
    }
}
