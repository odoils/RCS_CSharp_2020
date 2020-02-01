using System;

namespace Day_3_if__01._02._20
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cilveks ievada tris skaitlus - int
            //Jaizvada lielakais
            Console.WriteLine("ievadiet skaitli1");
            String ievade1 = Console.ReadLine();
            int skaitlis1 = Convert.ToInt32(ievade1);

            Console.WriteLine("ievadiet skaitli2");
            ievade1 = Console.ReadLine();
            int skaitlis2 = Convert.ToInt32(ievade1);

            Console.WriteLine("ievadiet skaitli3");
            ievade1 = Console.ReadLine();
            int skaitlis3 = Convert.ToInt32(ievade1);

            if (skaitlis1 >= skaitlis2 && skaitlis1 >= skaitlis3) 
            {
                Console.WriteLine("Lielakais skaitlis ir " + skaitlis1);
            }
            else if (skaitlis2 >= skaitlis1 && skaitlis2 >= skaitlis3)
            {
                Console.WriteLine("Lielakais skaitlis ir " + skaitlis2);
            }
            else if (skaitlis3 >= skaitlis1 && skaitlis3 >= skaitlis2)
            {
                Console.WriteLine("Lielakais skaitlis ir " + skaitlis3);
            }

            // 2. variants
            //int diggest = 0;
            //if 

        }
        static void piemers1()
        {

            int a = 5;
            int b = 6;
            // && - nozime UN
            // jaizpildas abam darbibas (jabut pareizam)

            if (a >= 5 && b == 6)
            {

            }

            // || - nozime vai ari
            //jaizpildas vienam

            if (a > 5 || b == 6)
            {

            }

            int skaitlis = 5;
            //#
            //##
            //###
            //>5, <5, ==5

            if (skaitlis > 5)
            {
                Console.WriteLine("#");
            }
            else if (skaitlis < 5)
            {
                Console.WriteLine("##");
            }
            else
            {
                Console.WriteLine("###");
            }
            // gadijums ar vairakiem 
            // and ir viens nosacijums

            static void piemers2()
            {
                //kalkulators
                //cilveks ievada divus skaitlus
                //cilveks ievada ko grib darit
                //uz ekrana izvada rezultatu
                // ja cilveks ka darbibu ievado ko citu paradas kluda

                Console.WriteLine("ievadiet skaitli");
                String ievade1 = Console.ReadLine();
                Double skaitlis1 = Convert.ToDouble(ievade1);

                Console.WriteLine("ievadiet darbibu +,-,*,/");
                String darbiba = Console.ReadLine();


                Console.WriteLine("ievadiet skaitli");
                ievade1 = Console.ReadLine();
                Double skaitlis2 = Convert.ToDouble(ievade1);

                if (darbiba == "+")
                {
                    Console.WriteLine("Rezultats ir " + (skaitlis1 + skaitlis2));
                }

                else if (darbiba == "-")
                {
                    Console.WriteLine("Rezultats ir " + (skaitlis1 - skaitlis2));
                }
                else if (darbiba == "*")
                {
                    Console.WriteLine("Rezultats ir " + (skaitlis1 * skaitlis2));
                }
                else if (darbiba == "/")
                {
                    Console.WriteLine("Rezultats ir " + (skaitlis1 / skaitlis2));
                }

                else
                {
                    Console.WriteLine("RKluda bija jaievada +,-,*,vai / ");
                }
            }
        }
    }
}
