using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_6
{
    public class ExampleClass //pirms class vajadzetu but public jo izmantojas public vai privat 
        //ja ir public - tad izmantot vat tikai klase, ja ir public tad var izmantot ari citas klases
    {
        public static void test()// so var izsaukt ari citas klases
        {
         Console.WriteLine ("Hellow ko skai")
        }

        private static void privattest()// so var izsaukt tikai saja 
        {
            Console.WriteLine("Hellow privatais");
        }

        public static int a = 5; //var izsaukt visur
        private static int b = 8;
    }
}
