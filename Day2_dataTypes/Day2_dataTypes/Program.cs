using System;

namespace Day2_dataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //sameklet ka parbaudit divus nosacijumus
            //un parbaudit vai cilveks ievada pareiza garuma String
            //un vai sis String ir vienads ar "aaaaaaaa"

            Console.WriteLine("Ievadiet simbolus");
            String garums = Console.ReadLine();
            

            if(garums.Length >= 8 && garums == "aaaaaaaa")
            {
                Console.WriteLine("viss OK");
            }
            else
            {
                Console.WriteLine("Nav OK");
            }
            




        }

        static void piemers()
        {
            int a = 5;
            int b = 7;
            int c = a + b;

            Console.WriteLine("Ievadiet skaitli!");
            String ievade = Console.ReadLine();

            int parkonvertetsNr = Convert.ToInt32(ievade);
            c = parkonvertetsNr - a;

            Console.WriteLine("Sakitlis ir "+ c);

            String virkne1 = "vertiba ";
            String virkne2 = "ir ";
            String virkne3 = virkne1 + virkne2;
            Console.WriteLine(virkne3);
        }

        static void piemers2 ()
        {
            int a = 5;
            int b = 6;
            if (a > 5)
            {
                Console.WriteLine("ir");
            }
            else
            {
                Console.WriteLine("nav");
            }

            //> vai < - lielaks/mazaks
            //<= - 
            //>= - 
            //== - (= ir pieskirts, == - salidzinat)
            //!= - nav vienads

            String piem = "aaa";
            if (piem == "aaa") ;// var salidzinat ari string  ir vienads vai nav

            // Stinga garuma merisana - int c = piem.Length;
        }


        static void uzdevums1()
        {

            //Lietotjam paprasam kurs gads ir
            //Lietotajs ievada
            //Lietotajam paparasam kura gada vins ir dzimis
            //Lietotajs ievada
            //Atnemas skaitlis lai izvaditu starpubu
            //izvadam vecums ir xx

            Console.WriteLine("Ievadiet sobridejo gada skaitli");
            String aktualaisgads = Console.ReadLine();
            int gads = Convert.ToInt32(aktualaisgads);

            Console.WriteLine("Ievadiet dzimsanas gadu");
            String dzimsanasgads = Console.ReadLine();
            int gads2 = Convert.ToInt32(dzimsanasgads);

            int vecums = gads - gads2;
            Console.WriteLine("Jusu vevums ir " + vecums);
        }
        static void uzdevums2()
        {
            //cielveks ievada skaitli
            //parbaudam vai ir lielaks par pieci
            //ja ir ##
            //ja nav #

            Console.WriteLine("Ievadiet skaitli");
            String ievade = Console.ReadLine();
            int skaitlis = Convert.ToInt32(ievade);
            if (skaitlis > 5)
            {
                Console.WriteLine("##");
            }
            else
            {
                Console.WriteLine("#");
            }
        }
    }
}
