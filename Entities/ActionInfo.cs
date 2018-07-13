using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AmamaNagigi.DeathReportPlugin.Entities
{
    /// <summary>
    /// 死に関係したアクション1行分のエンティティ
    /// </summary>
    [DataContract]
    public class ActionInfo
    {
        /// <summary>
        /// アクション実行者
        /// </summary>
        [DataMember(Name = "performer")]
        public string Performer { get; set; }

        /// <summary>
        /// アクション名
        /// </summary>
        [DataMember(Name = "name")]
        public string ActionName { get; set;  }

        /// <summary>
        /// アクション発生が死から何秒前か
        /// </summary>
        [DataMember(Name = "before")]
        public double Before { get; set; }

        /// <summary>
        /// アクションにより変化した値
        /// ダメージならマイナス、回復ならプラス
        /// </summary>
        [DataMember(Name = "point")]
        public long Point { get; set; }
    }
}
