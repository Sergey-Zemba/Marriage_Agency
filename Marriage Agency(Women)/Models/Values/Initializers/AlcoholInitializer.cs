using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Values.Initializers
{
    public class AlcoholInitializer : IValuesInitializer
    {
        public void Init(out IDictionary<int, ViewValue> dictionary)
        {
            dictionary = new Dictionary<int, ViewValue>
            {
                {1, new ViewValue(1, "Нет", "", "")},
                {2, new ViewValue(2, "Да, только по праздникам", "", "")},
                {3, new ViewValue(3, "Да, раз в месяц", "", "")},
                {4, new ViewValue(4, "Да, раз в неделю", "", "")}
            };
        }
    }
}