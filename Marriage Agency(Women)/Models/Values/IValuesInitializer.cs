using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace Marriage_Agency_Women_.Models.Values
{
    public interface IValuesInitializer
    {
        void Init(out IDictionary<int, ViewValue> dictionary);
    }
}

//dictionary = new Dictionary<int, ViewValue>
//            {
//                {1, new ViewValue(1, "", "", "")},
//                {2, new ViewValue(2, "", "", "")},
//                {3, new ViewValue(3, "", "", "")},
//                {4, new ViewValue(4, "", "", "")},
//                {5, new ViewValue(5, "", "", "")},
//                {6, new ViewValue(6, "", "", "")},
//                {7, new ViewValue(7, "", "", "")},
//                {8, new ViewValue(8, "", "", "")},
//                {9, new ViewValue(9, "", "", "")},
//                {10, new ViewValue(10, "", "", "")},
//                {11, new ViewValue(11, "", "", "")},
//                {12, new ViewValue(12, "", "", "")},
//                {13, new ViewValue(13, "", "", "")},
//                {14, new ViewValue(14, "", "", "")},
//                {15, new ViewValue(15, "", "", "")},
//                {16, new ViewValue(16, "", "", "")},
//                {17, new ViewValue(17, "", "", "")},
//                {18, new ViewValue(18, "", "", "")},
//                {19, new ViewValue(19, "", "", "")},
//                {20, new ViewValue(20, "", "", "")},
//                {21, new ViewValue(21, "", "", "")},
//                {22, new ViewValue(22, "", "", "")},
//                {23, new ViewValue(23, "", "", "")},
//                {24, new ViewValue(24, "", "", "")},
//                {25, new ViewValue(25, "", "", "")},
//                {26, new ViewValue(26, "", "", "")},
//                {27, new ViewValue(27, "", "", "")},
//                {28, new ViewValue(28, "", "", "")},
//                {29, new ViewValue(29, "", "", "")},
//                {30, new ViewValue(30, "", "", "")},
//                {31, new ViewValue(31, "", "", "")},
//                {32, new ViewValue(32, "", "", "")},
//                {33, new ViewValue(33, "", "", "")},
//                {34, new ViewValue(34, "", "", "")},
//                {35, new ViewValue(35, "", "", "")},
//                {36, new ViewValue(36, "", "", "")},
//                {37, new ViewValue(37, "", "", "")},
//                {38, new ViewValue(38, "", "", "")},
//                {39, new ViewValue(39, "", "", "")},
//                {40, new ViewValue(40, "", "", "")},
//                {41, new ViewValue(41, "", "", "")},
//                {42, new ViewValue(42, "", "", "")},
//                {43, new ViewValue(43, "", "", "")},
//                {44, new ViewValue(44, "", "", "")},
//                {45, new ViewValue(45, "", "", "")},
//                {46, new ViewValue(46, "", "", "")},
//                {47, new ViewValue(47, "", "", "")},
//                {48, new ViewValue(48, "", "", "")},
//                {49, new ViewValue(49, "", "", "")},
//                {50, new ViewValue(50, "", "", "")},
//                {51, new ViewValue(51, "", "", "")},
//                {52, new ViewValue(52, "", "", "")},
//                {53, new ViewValue(53, "", "", "")},
//                {54, new ViewValue(54, "", "", "")},
//                {55, new ViewValue(55, "", "", "")},
//                {56, new ViewValue(56, "", "", "")},
//                {57, new ViewValue(57, "", "", "")},
//                {58, new ViewValue(58, "", "", "")},
//                {59, new ViewValue(59, "", "", "")}
//            };