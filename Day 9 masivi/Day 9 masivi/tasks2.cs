using System;
using System.Collections.Generic;
using System.Text;

namespace Day_9_masivi
{
    class tasks2
    {
        // masivs ar 5 elementiem
        //string tipa
        // 4 elementus aizpilda cilveks
        // 5 elements gabajas ka ievadito 4 kopskaits P; as, os, is, us 5 bus asosisus
        // String a = "as" + "os" + "is" + "us"
        // izvadam 

        public static void ex2() 
        {
            String[] a = new String[5];

            for (int i = 0; i < a.Length -1; i++)
            {
                Console.WriteLine("ievadit " + (i + 1) + " garumu");
                a[i] = Console.ReadLine();
                a[4] = a[4] + a[1];
            }
            for (int i = 0; i < a.Length - 1; i++)
            {
                Console.WriteLine("Masiva vertiba ir " + a[i] + "");
            }
            
        }
    }
}
