using System;
using System.Collections.Generic;
using System.Text;

namespace MD_Masivi_23._02._20
{
    class Uzd4
    {
        public static void ex4()
        {
            Console.WriteLine("ievadit masiva garumu");
            int garums = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[garums];


            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("ievadit " + (i+1) + " garumu");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Masiva vertiba ir " + a[i] + "");
            }

        }
    }
}
