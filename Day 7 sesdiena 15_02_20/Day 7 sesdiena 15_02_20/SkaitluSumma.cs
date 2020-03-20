using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7_sesdiena_15_02_20
{
    class SkaitluSumma
    {

        private static int a = 0;
        private static int b = 0;
        public static void setA(int localA)
        {
            a = localA;
        }
        public static void setB(int localB)
        {
            b = localB;
        }

        public static int getC()
        {
            int c = a + b; // var ari sadi- Console.WriteLine("kopsumma ir " + (a+b));
            return c;
        }
        

        
    }
}
