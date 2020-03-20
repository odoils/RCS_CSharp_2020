using System;
using System.Collections.Generic;
using System.Text;

namespace Day_11_lists
{
    class task3
    {
        public static void Task3() 
        {
            // masivs ar 5 vertibam (string)
            // ievada cilveks
            // izvadam masivu
            //parbaudam katra elementa garumu
            // ja vairak par 5 simboliem, tad aizstajam elementu ar vii
            // izvadam masivu

            String[] a = new String[5];

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Ievadiet simbolus");
                a[i] = Console.ReadLine();

                //int b = a.Length; // izmera Stringa garumu

                if ( a.Length <= 5)
                {
                    Console.WriteLine(a[i] + "");
                }
                else if (a.Length > 5)
                {
                  
                    Console.WriteLine("vii");
                }

            }

        }

    }
}
