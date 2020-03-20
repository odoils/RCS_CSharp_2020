using System;
using System.Collections.Generic;
using System.Text;

namespace MD_Masivi_23._02._20
{
    class Uzd3
    {
        public static void ex3()
        {
            int[] a = new int[5];
            int c = 2;

            for (int i = 0; i < a.Length; i++)
            {               
                a[i] = c ;
                c = c + 2; //c+=2;
            }           

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + "");
            }
        }
    }
}
