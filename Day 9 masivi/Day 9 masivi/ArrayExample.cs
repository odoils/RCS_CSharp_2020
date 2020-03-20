using System;
using System.Collections.Generic;
using System.Text;

namespace Day_9_masivi
{
    public class ArrayExample
    {
        public ArrayExample()
        { 
        
        }
        public static void ex1()
        {
            int[] a = new int[5]; //5 norada cik masivs ir gars un tam jabut vienmer,
            a[0] = 4; //
            a[1] = 88;
            a[2] = 93;
            a[3] = 1;
            a[4] = 6;

            int[] c = { 4, 88, 93, 1, 6 }; //ja zina vertibas kadas jasavada tad var sadi

            string[] b = new string[3];// masivs vienmer saksies ar 0 (cikla var mainit )
            b[0] = "abc";
            b[1] = "Hello world";
            b[2] = "Wow";

            //Console.WriteLine(a); sadi nestradas masivu izvade//

            // var sadi//
            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]); // sadi gruti izvadit ja ir daudz vertibas jo katra jaizvada atseviski

            // lai izvaditu vairakus jaizmanto cikls
            for (int i = 0; i < a.Length; i++) // Length liekot ir drosak nenoradot cikla darbibas skaitu
            {
                Console.WriteLine(a[i]);
            }


        }

    }
}
