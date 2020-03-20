using System;
using System.Collections.Generic;
using System.Text;

namespace Day_11_lists
{
    class task2
    {

        public static void Task2()
        {
            // masivs ar 6 elementiem
            //[random = a] [a + b = c] [c + b = d] [d + b = e] [e + b] [random = b]
            // izvade

            int[] a = new int[100];

            Random random = new Random();
            a[0] = random.Next(1, 10);
            a[a.Length - 1] = random.Next(1, 10);

            for (int i = 1; i < a.Length - 1; i++)
            {

                a[i] = a[i - 1] + a[a.Length - 1];
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + "");
            }
        }
    }
}
