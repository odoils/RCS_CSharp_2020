using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_6
{
    class Uzdevums_Class
    {
        // uztaisiet divus privatus mainigos (int)
        // un uztaisiet ta, lai cilveks pieskir viniem vertibu
        // Console.ReadLine (ievade) notiek Proram.cs
        // lai main () vinus varetu izvadit
        // getA, setA

        private static int a = 0;
        private static int b = 0;

        public static void getA (int LocalA) 
        {
            a = LocalA;
        }

        public static int getA() 
        {
            return a;
        }
    }
}
