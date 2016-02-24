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
                {1, new ViewValue(1, "Должностное лицо", "Executive", "役員")},
                {2, new ViewValue(2, "Сотрудник компании", "Employee", "会社員")},
                {3, new ViewValue(3, "Частный предприниматель", "Self-employment", "自営業 ")},
                {4, new ViewValue(4, "Частный специалист", "Professional", "専門家 ")},
                {5, new ViewValue(5, "Госслужащий", "Public servant", "公務員")},
                {6, new ViewValue(6, "Студент", "Student", "学生 ")},
                {7, new ViewValue(7, "Домохозяйка", "Housewife", "家事手伝い ")},
                {8, new ViewValue(8, "Неполная занятость", "Underemployment", "パート")},
                {9, new ViewValue(9, "В поисках работы", "Looking for work", "無職")},
                {10, new ViewValue(10, "Другое", "Оther", "その他")}
            };
        }
    }
}