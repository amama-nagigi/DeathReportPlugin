using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AmamaNagigi.DeathReportPlugin.Entities
{
    /// <summary>
    /// 死んだときに発生するエンティティ
    /// </summary>
    [DataContract]
    public class DeathInfo
    {
        /// <summary>
        /// エンカウントID
        /// </summary>
        [DataMember(Name ="encStartTime")]
        public DateTime EncountStartTime { get; set; }

        /// <summary>
        /// 死んだ人の名前
        /// </summary>
        [DataMember(Name="victim")]
        public string Victim { get; set; }

        /// <summary>
        /// 殺した人の名前
        /// </summary>
        [DataMember(Name = "performer")]
        public string Performer { get; set; }

        /// <summary>
        /// 死亡時刻
        /// </summary>
        public DateTime DeathTime { get; set; }

        /// <summary>
        /// 死亡時刻HH:MM:SS形式
        /// </summary>
        [DataMember(Name = "time")]
        public String DeathTimeString { get; set; }

        /// <summary>
        /// 関連アクションリスト 死亡時刻に近い順にセット
        /// </summary>
        [DataMember(Name ="actions")]
        public List<ActionInfo> Actions { get; set; }
    }
}
