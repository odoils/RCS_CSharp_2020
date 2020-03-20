using System;
using System.Collections.Generic;
using System.Text;

namespace MD_Masivi_23._02._20
{
    class Uzd5
    {
        public static void ex4()
        {
            Console.WriteLine("ievadit masiva garumu");
            int garums = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[garums];


            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("ievadit " + (i + 1) + " vertibu");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0 ) // saja kodaa programma skatas kas ir aiz komata (ta nosaka vai para vai nepara) 
                    // 4/2 = 2,0 tatad para skaitlis 5/2 = 2,5 seit sanak aiz komata 5 lidz ar 
                    //ko nepara skaitlis
                {
                    Console.WriteLine("Nepara masiva vertiba ir " + a[i] + "");
                }
                
                
            }

        }

    }
}
