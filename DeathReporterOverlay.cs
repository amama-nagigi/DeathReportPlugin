using Advanced_Combat_Tracker;
using AmamaNagigi.DeathReportPlugin.Entities;
using RainbowMage.OverlayPlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmamaNagigi.DeathReportPlugin
{
    public class DeathReporterOverlay : OverlayBase<DeathReporterOverlayConfig>
    {
        private DeathReporterOverlayConfig config;
        private LogLineParser parser;

        public DeathReporterOverlay(DeathReporterOverlayConfig config) : base(config, config.Name)
        {
            this.config = config;

            // タイマー処理は行わない
            this.Stop();

            // パーサー作成
            this.parser = new LogLineParser(config);

            // イベントの登録
            ActGlobals.oFormActMain.OnLogLineRead += this.OnLogLineRead;

            // ページを表示
            Navigate(config.Url);
        }

        /// <summary>
        /// アップデート
        /// </summary>
        protected override void Update()
        {
            // Updateイベントでは何もしない
        }

        public void OnLogLineRead (bool isImport, LogLineEventArgs logInfo)
        {
            // 戦闘中のみ処理
            if (!logInfo.inCombat) return;

            DeathInfo info = parser.Parse(logInfo);

            if(info != null)
            {
                AddDeathReport(info);
            }
        }

        /// <summary>
        /// JSONをオーバーレイに追加する
        /// </summary>
        /// <param name="info"></param>
        private void AddDeathReport(DeathInfo info)
        {
            var json = parser.CreateJsonData(info);
            if (this.Overlay != null && this.Overlay.Renderer != null && this.Overlay.Renderer.Browser != null)
            {
                this.Overlay.Renderer.Browser.GetMainFrame().ExecuteJavaScript($"update({json});", null, 0);
            }
        }
    }
}
