using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7_sesdiena_15_02_20
{
    class trijsturis
    {
        private static int a = 0;
        private static int b = 0;
        private static int c = 0;
        public static void setA(int localA)
        {
            a = localA;
            
        }
        public static void setB(int localB)
        {
            b = localB;
            
        }
        public static void setC(int localC)
        {
            c = localC;
           
        }
        public static int perimetrs()
        {
            int perimetrs = a + b + c;
            if (perimetrs <= 0 && a <= 0 && b <= 0 && c <= 0)
            {
                Console.WriteLine("perimetru nevar aprekinat");
            }
           
            return perimetrs;//kludaina programma

            /*public static String perimetrs2()
            {
            int p = 0;

            if (a > 0 && b > 0 && c > 0)
            {
                p = a + b + c;
                return p.ToString();
            }
            return "Kluda!";*/

        }
    }

    
}
