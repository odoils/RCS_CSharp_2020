using System;

namespace Day_4_loops
{
    class Program
    {
        static void Main(string[] args) // CIKLI, lai kaut kadu darbibu atkartotu vairakas reizes
        {
             
            uzdevums4_1();
        }

        static void uzdevums4_1()
         //*
         //**
         //***
         //****
        {
            String b = (" ");
            String c = ("*");

            for (int i = 0; i < 4; i++)
            {
                b = b + c;
                Console.WriteLine(b);
            }

        }
        static void uzdevums4()        
         //*
         //**
         //***
         //****
         //***
         //**
         //*
        {
            String b = (" ");
            String c = ("*");
            
            
            for (int i = 0; i < 4; i++)
            {
                b = b + c;
                Console.WriteLine(b);              
            }
            for (int i = 0; i < 1; i ++)
            {
                Console.WriteLine(" *"+"*"+"*");
            }
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(" *" + "*");
            }
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(" *");
            }

        }

        static void uzdevums3()
            //cilveks ievada bazi (skaitli ko kapinat)
            //ievada pakapi
            //izvadam rezultatu
            //izmantojam veselus skaitlus
            //for ciklu
         
        {
            Console.WriteLine("ievadiet bazi");
            String sk1 = Console.ReadLine();
            int cipars = Convert.ToInt32(sk1);

            Console.WriteLine("ievadiet pakapi");
            sk1 = Console.ReadLine();
            int cipars2 = Convert.ToInt32(sk1);

            int b = cipars;// ja seit ievada (int b = 1) tad for (int i = 0;) 
                           // b katru reizi palilinas cikla
            for (int i = 1; i < cipars2; i++)// seit neliek i (<=) cipars2, paliek tikai (<)
            {
                b *= cipars; // pakape ar reiz nevis plus
            }
            Console.WriteLine("kopsumma ir " + b);


        }

        static void uzdevums2()
            // ievadam 5 skaitlus un izvadam skaitlu summu
        {
            int b = 0;
            for (int i = 1; i < 6; i++) 
            {
                Console.WriteLine("ievadiet ciparu");
                String fraze = Console.ReadLine();
                int cipars = Convert.ToInt32(fraze);
                b += cipars;
            }
            Console.WriteLine("kopsumma ir " + b);


        }

        static void uzdevums1()
            // ar for cikla palidzibu sasumet skaitlus no 1 lidz 10 
            // izvadit kopsummu
        {
            int b = 0; //sim jabut auksa preteja gadijuma neatpazis un proces nenotiek.
            for (int i = 1; i < 11; i++)
            {
                b += i; // (+) zimei jabut prieksa, lai saskaititu visus skaitlus kopa
                //Console.WriteLine(b); - ja ieliek so te, tad summu izmetis 10 reizes, jo ir ieksa cikla
            }
            Console.WriteLine(b);// ja seit tad vienu reizi jo izvade notiek arpus cikla

        }

        static void ciparuizvade() // jaizvada cipari no 1 lidz 100
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
            }


        }

        static void forLoopExample() 
        {
           for(int i = 0; i<5; i++)  
                // i++ nosaka ka katrs cikls ies pa vienam solim uz prieksu-> ( i=i+1)
                // i=0 - nosaka ar kadu ciparu saks skaitit
                // i<5 - nosaka ka cikls turpinasies lidz i bus mazaks par 5 uzliekot sadi i>5 cikls nestradas
                // i++ vieta ierakstos i=+2 - sanak ka katra reize pieskaitisies pa 2.
           {
                Console.WriteLine("ievadiet frazi");
                String fraze = Console.ReadLine();

                Console.WriteLine("Cikla pielietojums ->" + i);
           }

            static void whileUnDoWhile() 
            {
                int a = 0;

                while (a < 10) 
                {
                    
                }
                  // Do..while ieiet cikla vismaz vienu reizi (ja a>=10)
                do
                {
                    Console.WriteLine("Cikla pielietojums" + a);
                    a++;
                } while (a < 10);
            }
        
        }
    }
}
