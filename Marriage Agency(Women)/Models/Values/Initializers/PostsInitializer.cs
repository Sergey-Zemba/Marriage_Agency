using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Values.Initializers
{
    public class PostsInitializer : IValuesInitializer
    {
        public void Init(out IDictionary<int, ViewValue> dictionary)
        {
            dictionary = new Dictionary<int, ViewValue>
            {
                {1, new ViewValue(1, "Должностное лицо", "", "")},
                {2, new ViewValue(2, "Сотрудник компании", "", "")},
                {3, new ViewValue(3, "Частный предприниматель", "", "")},
                {4, new ViewValue(4, "Частный специалист", "", "")},
                {5, new ViewValue(5, "Госслужащий", "", "")},
                {6, new ViewValue(6, "Студент", "", "")},
                {7, new ViewValue(7, "Домохозяйка", "", "")},
                {8, new ViewValue(8, "Неполная занятость", "", "")},
                {9, new ViewValue(9, "В поисках работы", "", "")},
                {10, new ViewValue(10, "Другое", "", "")}
            };
        }
    }
}