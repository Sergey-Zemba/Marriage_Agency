using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Values.Initializers
{
    public class RelationshipsInitializer : IValuesInitializer
    {
        public void Init(out IDictionary<int, ViewValue> dictionary)
        {
            dictionary = new Dictionary<int, ViewValue>{
                {1, new ViewValue(1, "Нет", "No", "なし")},
                {2, new ViewValue(2, "Была замужем", "Yes", "あり")},
                {3, new ViewValue(3, "Вдова", "Widow", "未亡人")},
                {4, new ViewValue(4, "В отношениях", "NO", "なし")}
            };
        }
    }
}