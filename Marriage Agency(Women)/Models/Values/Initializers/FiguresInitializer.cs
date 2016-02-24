using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Values.Initializers
{
    public class FiguresInitializer : IValuesInitializer
    {
        public void Init(out IDictionary<int, ViewValue> dictionary)
        {
            dictionary = new Dictionary<int, ViewValue>
            {
                {1, new ViewValue(1, "Худое", "Slender", "細身")},
                {2, new ViewValue(2, "Спортивное", "Athletic", "アスリート")},
                {3, new ViewValue(3, "Стандартное", "Standards", "標準")},
                {4, new ViewValue(4, "Роскошное", "Voluptuous", "官能的")},
                {5, new ViewValue(5, "Полное", "Plump", "豊満")}
            };
        }
    }
}