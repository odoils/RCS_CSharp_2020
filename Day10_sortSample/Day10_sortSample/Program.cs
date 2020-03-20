using System;

namespace Day10_sortSample
{
    public class Bubble_Sort
    {
        static void Main(string[] args) 
        {
            uzd2();
        }

        static void uzd3()
        {
            Console.WriteLine("ievadiet vardu kas jaatmin");
            String ievade = Console.ReadLine();

            string[] a = new string[1];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ievadit " + (i + 1) + "burtu");
                String burts = Console.ReadLine();
            }
                int t = 0;

            for (int p = 0; p < a.Length; p++)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }

            /*for (int i = 5; i > 0; i--)
            {
                Console.WriteLine("ievadiet burtu" + i + "meiginajumi");
                Console.WriteLine("varda garums" + minamais.Length);

                String ievade = Console.ReadLine();
                if (ievade == minamais)
                {
                    Console.WriteLine("uzvar otrais speletajs");
                    break;
                }
                if (ievade != minamais && i == 1)
                {
                    Console.WriteLine("Jus uzvarejat");
                }
            }*/

        }




        static void uzd2()
        {                                                
            int[] a = new int[10];// sakarto masivus augosa seciba
                
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("ievadit " + (i + 1) + " vertibu");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int t = 0;

            for (int p = 0; p < a.Length; p++)
            {
                for (int i = 0; i < a.Length-1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }                   
                }                
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + "");
            }




        }
        static void uzd()                               
        {
            int a = 10;
            int b = 12;
            // uztaisit, lai a vertiba butu 12 un b vertiba butu 10.
            int c = a;
            a = b;
            b = c;
            
        }
    }
}
