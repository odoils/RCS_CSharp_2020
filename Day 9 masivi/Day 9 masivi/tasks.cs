using System;
using System.Collections.Generic;
using System.Text;

namespace Day_9_masivi
{
    public class tasks
    {
        // Uztaisit masivu, kuram garumu ievada lietotajs
        //pec tam, lai lietotajs so masivu aizpilda
        // ar izveletam vertibam
        //aizpildisanai for cikls
        //izvada masivu

        public static void ex1() 
        {
            Console.WriteLine("ievadit masiva garumu");         
            int garums = Convert.ToInt32(Console.ReadLine());
           
            int[] a = new int[garums];//  pieskir masivam garumu


            for (int i = 0; i < a.Length; i++)//seit nodrosina ka var pievienot katram masivam vertibu
                                              // cikls nodrosina masiva garumu kam pieskirt vertibu
            {
                Console.WriteLine("ievadit " + i +  " garumu");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++) // nodrosina visu masivu izvade
            {               
                Console.WriteLine("Masiva vertiba ir " + a[i] + "");
            }

        }
    }
}
