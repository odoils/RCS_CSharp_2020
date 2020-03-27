using System;

namespace Dau_3__2_dala_01._02._20
{
    class Program
    {
        static void Main(string[] args)
        {
            /*bool a = true;
            a = false;
            a = !a;
            Console.WriteLine(a);*/

            //Cilveks ievada skaitli
            //Uztaisam metodi kas atgriez (return) vai skaitlis ir pozitivs vai negativs

            Console.WriteLine("ievadiet skaitli1");
            String ievade1 = Console.ReadLine();
            int sk1 = Convert.ToInt32(ievade1);

            if (sk1 > 0)
            {
                Console.WriteLine( "Skaitlis ir pozitivs");
            }
            else if (sk1 == 0)
            {
                Console.WriteLine("Skaitlis ir nulle");
            }
            else
            {
                Console.WriteLine("Skaitlis ir negativs");
            }
        }

        static void metode(int a) 
        {
            if (a > 0)
            {
                Console.WriteLine();
            }
            else if (a==0)
            {
                Console.WriteLine();
            }
            else 
            {
                Console.WriteLine();
            }
            

        }

        static void formulsamazin()
        {
            // Cilveks ievada tris skaitlus - int
            // Jaizvada lielakais
            // Formulas samazinasana

            int sk1 = ievade();
            int sk2 = ievade();
            int sk3 = ievade();

            uzd1(sk1, sk2, sk3); 
            

        }

        static int ievade()
        {
            Console.WriteLine("ievadiet skaitli1");
            String ievade1 = Console.ReadLine();
            int sk1 = Convert.ToInt32(ievade1);
            return sk1;

            /* vai 
            Console.WriteLine("ievadiet skaitli1");
            return Convert.ToInt32(Console.ReadLine());*/
        }


        static void uzd1(int a, int b, int c)
        {
            int biggest = 0;

            if (a > b)
            {
               biggest = a;
            }
            else
            {
               biggest = b;
            }
            if (biggest < c)
            {
               biggest = c;
            }           

            Console.WriteLine("Rezultats ir " + biggest);

            /* vai var 
            static int biggestNumer (int a, int b)
            if (a>b)
            {
              return a;
            }
            else
            {
              return b;
            }*/
        }







        static void dala()
        {
            /*piemers1();
            piemers2();
            piemers3(3,7); // iekavas janorada tas kadu metodi izmantojam Void ja ir int tad skaitli 
                           //ja ir String tas simboli
            int c = piemers4();*/

            // - /* sakuma un */ beigs var vairakas rindas uztausit ka komentaru

            //1. saskaitisana
            //ievads Main metode, padodam skaitlus uz musu izveidoto metodi ka parametrus
            // izvade notiek tur
            Console.WriteLine("ievadiet skaitli 1");
            String ievade = Console.ReadLine();
            int sk1 = Convert.ToInt32(ievade);

            Console.WriteLine("ievadiet skaitli 1");
            ievade = Console.ReadLine();
            int sk2 = Convert.ToInt32(ievade);

            uzdevums1(sk1, sk2);

            //2. Ievade notiek musu izveidotaja metode
            //rezultatu atgriezas ar retun un izvadam Mein

            Console.WriteLine("Rezultats ir" + uzdevums2());

            //3. Apvienojam 1 un 2.
            //visa ievade/izvade notiek main (gan parametri, gan return)

            Console.WriteLine("Rezultats ir" + uzdevums3(sk1, sk2));

        }
        static void uzdevums1(int a, int b)
        {
            Console.WriteLine("rezultats ir " + a + b);
        }

        static int uzdevums2()
        {
            Console.WriteLine("ievadiet skaitli 1");
            String ievade = Console.ReadLine();
            int sk3 = Convert.ToInt32(ievade);

            Console.WriteLine("ievadiet skaitli 1");
            ievade = Console.ReadLine();
            int sk4 = Convert.ToInt32(ievade);

            return sk3 + sk4;
        }

        static int uzdevums3(int a, int b)
        {
            return a + b;
        }

       
        static void piemers1()
        {
            Console.WriteLine("Parasta void metode");
            piemers2(); // sadi viena metode izsauc otru, var izsaukt gan seit gan Main (sk. augstak)
        }
        static void piemers2 ()
        {
            // metodes obligati ir jaizsauc no Main vai no citas metodes (static void) 
            Console.WriteLine("Velviena void metode");
        }

        static void piemers3(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static int piemers4()
        {
            int sk1 = 5;
            int sk2 = 6;

            return sk1 + sk2;
        }
        static String piemers5() 
        {
            Console.WriteLine("ievadiet kaut ko");
            String ievade = Console.ReadLine();

            return ievade;

        }


        
    }
}
