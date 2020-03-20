using System;

namespace Day8__objects
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // izveido jaunu klasi
            // jabut laukam kur glabajas int
            // 1-10 (konstruktora generejam)
            // getNumber, kas atgriez so skaitli
            // regeneretNumber() - no jauna uzgenere gadijuma skaitli

            // uztaisa vienu obj un otru no Main
            // whilde cikls
            // salidzinam abju objektu gadijuma skaitlus
            // kuram lielaks, tas uzvar
            // ka piefikset uzvaras - katrs pats izdoma
            // apstajamies, kad viens objekts ir uzvarejis 3 reizes

            /*Random random = new Random();
            int number = random.Next(1, 10);*/

            Spele ex = new Spele();
                    
            Spele ex2 = new Spele();
             
                   

            while (ex.getWins() < 3 && ex2.getWins < 3)
            {
                i++;
                Console.WriteLine();
                if (ex.getNumber() > ex2.newRandom())
                {
                    ex.addWin();
                }
                else if (b > a)
                {
                    
                }

                ex.GenerateRandom;
                ex2.GenerateRandom;

 
            }

            

                



                

            


        }

        public void uzd1()
        {
            Rinkis ex =new Rinkis(5); // sis ir japarbauda pie pasniedzeja GitHub
            ex.print();
            ex.print2();
        }

        public double ievade()         
        {
            Console.WriteLine("ievadiet radiusu");
            return Convert.ToDouble (Console.ReadLine());

        }
    }
}
