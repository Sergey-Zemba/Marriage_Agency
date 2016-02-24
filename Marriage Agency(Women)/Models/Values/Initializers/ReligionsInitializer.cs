using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Values.Initializers
{
    public class ReligionsInitializer : IValuesInitializer
    {
        public void Init(out IDictionary<int, ViewValue> dictionary)
        {
            dictionary = new Dictionary<int, ViewValue>
            {
                {1, new ViewValue(1, "Христианство", "Christian", "キリスト教")},
                {2, new ViewValue(2, "Мусульманство", "Muslim", "イスラム教")},
                {3, new ViewValue(3, "Буддизм", "Buddhism", "仏教")},
                {4, new ViewValue(4, "Иррелигиозность", "Irreligion", "無宗教")},
                {5, new ViewValue(5, "Другое", "Оther", "その他")}
            };
        }
    }
}