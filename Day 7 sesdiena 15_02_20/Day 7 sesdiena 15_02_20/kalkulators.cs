using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7_sesdiena_15_02_20
{
    class kalkulators
    {
        private static String a = ("");
        private static int sk1 = 0;
        private static int sk2 = 0;

        public static void setB(string darbiba)
        {
            a = darbiba;
        }
        public static void setA(int skaitlis1)
        {
            sk1 = skaitlis1;
        }
        public static void setC(int skaitlis2)
        {
            sk2 = skaitlis2;
        }

        public static int Print()
        {
            if (a == "+")
            {
                return (sk1 + sk2);
            }

            else if (a == "-")
            {
                return (sk1 - sk2);
            }
            else if (a == "*")
            {
                return (sk1 * sk2);
            }
            else if (a == "/")
            {
                return (sk1 / sk2);
            }

            
        }
    }
}
