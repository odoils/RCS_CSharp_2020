using System;

namespace Day_7_sesdiena_15_02_20
{
    class Program
    {
        static void Main(string[] args)
        {
            uzd4_1();
        }

        static void uzd4_1()
        //Uztaisit vienu statisku klasi, kura ir viena metode, kas atgriez
        //double tipa skaitli pec cilveka ievades
        {
            Statiskaklase.metode();
        }

        static void uzd4_2()
        //Uztaisit statisku klasi, kur ir metodes: saskaitit, atnemt, reizinat, dalit
        //padodam skaitlus ieksa ka parametrus katrai metodei atseviski

        // no Main cilveks ievada skaitli 1, skaitli 2, izvelas darbibu
        // izvadam rezultatu
        {
            Console.WriteLine("ievadiet skaitli");
            String ievade1 = Console.ReadLine();
            int skaitlis1 = Convert.ToInt32(ievade1);

            Console.WriteLine("ievadiet darbibu +,-,*,/");
            String darbiba = Console.ReadLine();


            Console.WriteLine("ievadiet skaitli");
            ievade1 = Console.ReadLine();
            int skaitlis2 = Convert.ToInt32(ievade1);

            kalkulators.setA(skaitlis1);
            kalkulators.setB(darbiba);
            kalkulators.setC(skaitlis2);

            Console.WriteLine("rezultats ir " + kalkulators.Print();
        }
         


        static void uzd3() 
         //Klase ar nosaukumu "Students"
         //Klases konstruktors ar parametriem
         //Vards, Uzvards, Kurss, iestasanas gads
         //Kurss - 1 lidz 3
         // ja ir varak ka 3 tad istatam 3
         // ja ir mazak ka 1 tad iestatam 1
        
        {
            Students obj = new Students("Gatis", "Berzins", 2, 2021);
            obj.print();

            Students obj2 = new Students("Juris", "Ozols", -9, 2019);
            obj2.print();

        }

        static void objEx2()


        {
           TristurisObj tr1 = new TristurisObj(3,5,3);    
           tr1.print();

           TristurisObj tr2 = new TristurisObj(0,5,0);
            tr2.print();
        }

        
        
            
         static void objEx1() // piemers ja izmanto metodes kas nav static, 
            //to izmanto ja vienu metodi vajad izmantot vairakiem objektiem
            //
         {
                OjbExample obj = new OjbExample(0,0);
                obj.setA(1);
                obj.setB(2);
                obj.print();

                obj.setA(5);
                obj.print();

                OjbExample obj2 = new OjbExample(0,0);
                obj2.print();

                OjbExample obj3 = new OjbExample(3, 7);
                obj3.print();
         }
                
        static void uzd2()// piemers ja tiek izmantotas static metobes
        {
            //klases nosaukums ir trijsturis
            //cilveks ievada 3 malu vertibas -mainigie jaunaja klase
            // Metodi, kas izvada perimetru 
            
            Console.WriteLine("ievadiet malu 1");
            String ievade = Console.ReadLine();
            int pirmais = Convert.ToInt32(ievade);

            Console.WriteLine("ievadiet malu 2");
            ievade = Console.ReadLine();
            int otrais = Convert.ToInt32(ievade);

            Console.WriteLine("ievadiet malu 3");
            ievade = Console.ReadLine();
            int tresais = Convert.ToInt32(ievade);

            trijsturis.setA(pirmais);
            trijsturis.setB(otrais);
            trijsturis.setC(tresais);

            Console.WriteLine("trijstura perimetrs ir " + trijsturis.perimetrs());
            
            //
        }
        
        
        
         static void uzd1()
         {
            //uztaisat jaunu klasi ar nosaukumu "Skaitlu summa"
            // ievadat 2 int tipa skaitlus no Main
            // uztaisat get set un lai butu publiska metode, kas izvada
            // abu skaitlu summu
            //abiem skaitliem jabut pieeejamiem visa SkaitluSumma klase
            //bet no Program.cs klases tikai ar get un set
           
            Console.WriteLine("ievadiet skaitli 1");
            String ievade = Console.ReadLine();
            int pirmais = Convert.ToInt32(ievade);

            Console.WriteLine("ievadiet skaitli 2");
            ievade = Console.ReadLine();
            int otrais = Convert.ToInt32(ievade);

            SkaitluSumma.setA(pirmais);
            SkaitluSumma.setB(otrais);

            Console.WriteLine("kopsumma ir " + SkaitluSumma.getC());
         }

         
    }
}
