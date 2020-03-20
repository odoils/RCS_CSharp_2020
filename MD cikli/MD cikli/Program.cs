using System;

namespace MD_cikli
{
    class Program
    {
        static void Main(string[] args)
        {
            MD2();
        }

        static void MD3()
        {
            for (int i = 0; i < 6; i++) 
            {
                Console.WriteLine("ievadiet skaitli");
                String input = Console.ReadLine();
                input = input.ToUpper();// ToUpeper, ToLower
                if (input == "Y")
                {
                    break;// lai partrauktu cikla darbibu
                }
                else 
                {
                    Console.WriteLine(i);
                }

            }
        
        
        
        }
        static void MD2()
        {
            String i = "";
            while (i != "no")
            {
                Console.WriteLine("ievadiet skaitli");
                String sk1 = Console.ReadLine();
                Double cipars = Convert.ToDouble(sk1);

                Console.WriteLine("ievadiet darbibu");
                String sk2 = Console.ReadLine();

                Console.WriteLine("ievadiet skaitli");
                sk1 = Console.ReadLine();
                Double cipars2 = Convert.ToDouble(sk1);

                if (sk2 == "+")
                {
                    Console.WriteLine("Rezultats ir " + (cipars + cipars2));
                }
                else if (sk2 == "-")
                {
                    Console.WriteLine("Rezultats ir " + (cipars - cipars2));
                }
                else if (sk2 == "*")
                {
                    Console.WriteLine("Rezultats ir " + (cipars * cipars2));
                }
                else if (sk2 == "/")
                {
                    Console.WriteLine("Rezultats ir " + (cipars / cipars2));
                }
              
                Console.WriteLine("vai turpinat");
                i = Console.ReadLine();
                                  
            }


            

        }
        static void MD1()
        {
            Console.WriteLine("ievadiet bazi");
            String sk1 = Console.ReadLine();
            int cipars = Convert.ToInt32(sk1);

            int b = 1;
            for (int i = 1; i < (cipars + 1); i++)
            {
                b *= i;
                Console.WriteLine("kopsumma ir " + b);
            }


        }
    }
}
