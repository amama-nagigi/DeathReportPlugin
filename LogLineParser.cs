using Advanced_Combat_Tracker;
using AmamaNagigi.DeathReportPlugin.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AmamaNagigi.DeathReportPlugin
{
    public class LogLineParser
    {
        /// <summary>
        /// 死亡ログ取得用正規表現
        /// </summary>
        private static readonly Regex re = new Regex(@"^\[(?<time>[0-9]{2}:[0-9]{2}:[0-9]{2})\.[0-9]{3}\] 19:(?<victim>.*) was defeated by (?<performer>.*)\.$");

        /// <summary>
        /// 集計対象となるSwingType
        /// </summary>
        private List<int> targetSwingType;

        private DeathReporterOverlayConfig config;

        /// <summary>
        /// 初期化子
        /// </summary>
        public LogLineParser(DeathReporterOverlayConfig config)
        {
            // 設定への参照を設定
            this.config = config;

            // 集計対象のSwingTypeを初期化
            targetSwingType = InitializeTargetSwingType();
        }

        /// <summary>
        /// 集計対象となるSwingTypeを取得
        /// </summary>
        private List<int> InitializeTargetSwingType()
        {
            var list = new List<int>();

            foreach (var inc in CombatantData.SwingTypeToDamageTypeDataLinksIncoming)
            {
                // IncomingDamageを追加
                if (inc.Value.Contains(CombatantData.DamageTypeDataIncomingDamage) || inc.Value.Contains(CombatantData.DamageTypeDataIncomingHealing))
                {
                    list.Add(inc.Key);
                }
            }

            return list;
        }

        public DeathInfo Parse(LogLineEventArgs logInfo)
        {
            var match = re.Match(logInfo.logLine);
            if (match.Success)
            {
                // アクションのターゲットと実行者を取得
                var victim = match.Groups["victim"].Value;
                var performer = match.Groups["performer"].Value;
                var deathTimeString = match.Groups["time"].Value;

                // 現在の戦闘を取得
                var encounter = ActGlobals.oFormActMain.ActiveZone.ActiveEncounter;

                // 犠牲者の戦闘データを取得
                var combatantData = encounter.GetCombatant(victim);

                // 犠牲者が敵でなかった場合のみ処理
                if (combatantData != null && combatantData.GetCombatantType() != 0)
                {
                    // 実行時間をパース
                    var deathTime = logInfo.detectedTime;

                    // 基本的な情報をセット
                    var d = new DeathInfo()
                    {
                        EncountStartTime = encounter.StartTime,
                        Victim = victim,
                        Performer = performer,
                        DeathTime = deathTime,
                        DeathTimeString = deathTime.ToString("HH:mm:ss")
                    };

                    // ログ集計
                    var sec = this.config.SecBeforeDeath;
                    var swings = combatantData.AllInc["All"].Items.Where((e) =>
                    {
                        // Killingは除外
                        if (e.AttackType == "Killing") return false;

                        // 時間でフィルタ
                        TimeSpan ts = deathTime.Subtract(e.Time);
                        if (ts.TotalSeconds > sec) return false;

                        // Victimがやられた人じゃない場合は除外
                        if (e.Victim != combatantData.Name) return false;

                        // 割り込みは除外
                        if (e.Special == "Interrupted") return false;

                        // 対象のSwingTypeのみ集計
                        return this.targetSwingType.Contains(e.SwingType);
                    }).ToList();

                    d.Actions = swings.Select((e) =>
                    {
                        var actionInfo = new ActionInfo()
                        {
                            ActionName = e.AttackType,
                            Before = (d.DeathTime - e.Time).TotalSeconds,
                            Performer = e.Attacker,
                            Point = CombatantData.DamageSwingTypes.Contains(e.SwingType) ? -e.Damage.Number : e.Damage.Number
                        };
                        return actionInfo;
                    }).ToList();

                    return d;
                }
            }
            return null;
        }

        /// <summary>
        /// ログをjson化する
        /// </summary>
        /// <param name="deathInfo"></param>
        /// <returns></returns>
        public string CreateJsonData(DeathInfo deathInfo)
        {
            using (var ms = new MemoryStream())
            using (var sr = new StreamReader(ms))
            {
                var serializer = new DataContractJsonSerializer(typeof(DeathInfo));
                serializer.WriteObject(ms, deathInfo);
                ms.Position = 0;

                return sr.ReadToEnd();
            }
        }
    }
}
