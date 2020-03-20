using System;

namespace DAY_6
{
    class Program
    {
        static void Main(string[] args)       
        {
            Console.WriteLine (Uzdevums_Class.getA);

            Console.WriteLine("ievadiet skaitli 1");
            String sk1 = Console.ReadLine();
            int pirmais = Convert.ToInt32(sk1);

            Console.WriteLine("ievadiet skaitli 2");
            sk1 = Console.ReadLine();
            int otrais = Convert.ToInt32(sk1);

            Uzdevums_Class.getA(pirmais);
            Console.WriteLine(Uzdevums_Class.getA);
        }

        static void P()
        {
            ExampleClass.test();
            Console.WriteLine(ExampleClass.a);
        }
    }
}
