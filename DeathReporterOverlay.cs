﻿using Advanced_Combat_Tracker;
using AmamaNagigi.DeathReportPlugin.Entities;
using AmamaNagigi.DeathReportPlugin.Util;
using RainbowMage.OverlayPlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainbowMage.HtmlRenderer;

namespace AmamaNagigi.DeathReportPlugin
{
    public class DeathReporterOverlay : OverlayBase<DeathReporterOverlayConfig>
    {
        private LogLineParser parser;

        public DeathReporterOverlay(DeathReporterOverlayConfig config) : base(config, config.Name)
        {
            // タイマー処理は行わない
            this.Stop();

            // パーサー作成
            this.parser = new LogLineParser(config);

            // イベントの登録
            ActGlobals.oFormActMain.OnLogLineRead += this.OnLogLineRead;
            ActGlobals.oFormActMain.OnCombatStart += this.OnCombatStart;
            this.Overlay.Renderer.BrowserLoad += this.OnBrowserLoad;

            // ページを表示
            Navigate(config.Url);
        }

        /// <summary>
        /// ブラウザロード時に設定情報を渡す
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBrowserLoad(object sender, BrowserLoadEventArgs e)
        {
            var config = JsonUtil.CreateJsonData(this.Config.AddonConfig);
            ExecuteScript($"loaded({config})");
        }

        /// <summary>
        /// ブラウザスクリプト実行
        /// </summary>
        /// <param name="script"></param>
        private void ExecuteScript(string script)
        {
            if (this.Overlay != null && this.Overlay.Renderer != null && this.Overlay.Renderer.Browser != null)
            {
                // スクリプト実行
                this.Overlay.Renderer.Browser.GetMainFrame().ExecuteJavaScript(script, null, 0);
            }
        }

        /// <summary>
        /// 戦闘開始イベント
        /// </summary>
        /// <param name="isImport"></param>
        /// <param name="encounterInfo"></param>
        private void OnCombatStart(bool isImport, CombatToggleEventArgs encounterInfo)
        {
            // 戦闘開始を伝える
            ExecuteScript($"startCombat('{encounterInfo.encounter.StartTime}');");
        }

        /// <summary>
        /// アップデート
        /// </summary>
        protected override void Update()
        {
            // Updateイベントでは何もしない
        }

        /// <summary>
        /// ログ読み込み時イベント
        /// </summary>
        /// <param name="isImport"></param>
        /// <param name="logInfo"></param>
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
            var json = JsonUtil.CreateJsonData(info);
            if (this.Overlay != null && this.Overlay.Renderer != null && this.Overlay.Renderer.Browser != null)
            {
                ExecuteScript($"update({json});");
            }
        }

        /// <summary>
        /// ダミーデータをオーバーレイに追加する
        /// </summary>
        public void AddDummyDeathReport()
        {
            // 時刻を作成
            var time = DateTime.Now;

            // ダミーデータ作成
            var d = new DeathInfo()
            {
                Actions = new List<ActionInfo>(),
                DeathTime = time,
                EncountStartTime = time,
                Performer = "エネミー",
                Victim = "Player One",
            };

            // ダミーデータ明細を作成
            d.Actions.Add(new ActionInfo()
            {
                Performer = "エネミー",
                ActionName = "攻撃",
                Before = 3.0,
                Point = -10000
            });

            d.Actions.Add(new ActionInfo()
            {
                Performer = "Player Two",
                ActionName = "回復",
                Before = 2.0,
                Point = 5000
            });

            d.Actions.Add(new ActionInfo()
            {
                Performer = "エネミー",
                ActionName = "攻撃",
                Before = 1.0,
                Point = -30000
            });

            // 同じデータを3回送信
            AddDeathReport(d);
            AddDeathReport(d);
            AddDeathReport(d);
        }
    }
}
