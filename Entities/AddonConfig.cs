using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AmamaNagigi.DeathReportPlugin.Entities
{
    [DataContract]
    public class AddonConfig
    {
        /// <summary>
        /// 直前何秒のログを吐くか
        /// </summary>
        [DataMember(Name = "sec")]
        public int SecBeforeDeath { get; set; }

        /// <summary>
        /// 最大表示数
        /// </summary>
        [DataMember(Name = "maxCount")]
        public int MaxCount { get; set; }

        /// <summary>
        /// ログを初期状態で展開するかどうか
        /// </summary>
        [DataMember(Name = "isExpanded")]
        public bool IsExpanded { get; set; }

        /// <summary>
        /// 戦闘開始時に表示をクリアするかどうか
        /// </summary>
        [DataMember(Name = "clearOnStart")]
        public bool ClearOnStart { get; set; }
    }
}
