using AmamaNagigi.DeathReportPlugin.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace AmamaNagigi.DeathReportPlugin.Util
{
    public static class JsonUtil
    {
        /// <summary>
        /// オブジェクトからJSONデータを作成
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string CreateJsonData<T>(T obj)
        {
            using (var ms = new MemoryStream())
            using (var sr = new StreamReader(ms))
            {
                var serializer = new DataContractJsonSerializer(typeof(T));
                serializer.WriteObject(ms, obj);
                ms.Position = 0;

                return sr.ReadToEnd();
            }
        }
    }
}
