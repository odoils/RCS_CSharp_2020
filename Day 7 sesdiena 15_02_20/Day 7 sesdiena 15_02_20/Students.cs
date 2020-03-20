using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7_sesdiena_15_02_20
{
    class Students
    {
        private String Vards;
        private String Uzvards;
        private int Kurss;
        private int gads;

        public Students(String Vards, String Uzvards, int Kurss, int gads)
        {
            if (Kurss > 3)// ja If formulu liek zem this.Vards utt. tad kursa vieta jaraksta this.kurss
            {
                Kurss = 3;
            }
            else if (Kurss < 1)
            {
                Kurss = 1;
            }

            this.Vards = Vards;
            this.Uzvards = Uzvards;
            this.Kurss = Kurss;
            this.gads = gads;
                   
        }

        public void print()
        {
            Console.WriteLine("Vards- " + Vards);
            Console.WriteLine("Uzvards- " + Uzvards);
            Console.WriteLine("Kursa Nr- " + Kurss);
            Console.WriteLine("iestasanas gads- " + gads);

            Console.WriteLine();// so ielikot ka tuksu tad starp abiem objetiem uz ekrana bus starpa 

        }
    }
}
