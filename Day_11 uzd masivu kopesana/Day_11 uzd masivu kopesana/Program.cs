using System;

namespace Day_11_uzd_masivu_kopesana
{
    class Program
    {
        static void Main(string[] args)
        {
            // Masivs ar 5 veriban
            //aizpilda masivu ar random skaitliem
            //Cilveks ievada velamo masiva garumu
            // Ja ie ievaditi 5 un mazak, tad izvadam
            //ja ir vairak tad ir jasaglaba vecas vertibas un japardefine masivs
            //vecas vertibas ievietojam atpakal un pieliekam jaunas
            
            
            int[] a = new int[5];

            for (int i = 0; i < a.Length; i++)
            {
                Random random = new Random();
                a[i] = random.Next(1,100);
            }

            Console.WriteLine("Ievadiet masiva garumu");
            int len = Convert.ToInt32(Console.ReadLine());            

            if (len <= 5)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine(a[i] + "");
                }
            }

            else  //  sadi saglaba pirma masiva vertibas       
            {
                int[] temp = new int[a.Length]; //izveido jaunu masicu kura saglabajas pirma masiva vertibas
                for (int i = 0; i < a.Length; i++)
                {
                    temp[i] = a[i];
                }

                a = new int[len];
                for (int i = 0; i < temp.Length; i++)
                {
                    a[i] = temp[i];
                }
                for (int i = temp.Length; i < a.Length; i++)
                {
                    Random random = new Random();
                    a[i] = random.Next(1,100); // iekavas nosaka robezas kadas itks izvaditi nejausie (random) skaitli
                }

                int t = 0; //sis sakarto pec kartas masiva vertibas (so piliku pats klat pie uzdevuma)

                for (int p = 0; p < a.Length; p++)
                {
                    for (int i = 0; i < a.Length - 1; i++)
                    {
                        if (a[i] > a[i + 1])
                        {
                            t = a[i + 1];
                            a[i + 1] = a[i];
                            a[i] = t;
                        }
                    }
                }

                for (int i = 0; i < a.Length; i++)// sis izvada
                {
                    Console.WriteLine(a[i] + "");
                }

            }



            //OTRS VARIANTA

            /*else // sadi nesaglaba iepriekseja masiva vertibas bet genere tas par jaunam
            {
                int[] h = new int[len];
                for (int i = 0; i < a.Length; i++)
                {
                    h[i] = a[i];
                    
                    Random random = new Random();
                    h[i] = random.Next();
                }

                for (int i = a.Length; i < h.Length; i++)
                {
                    Random random = new Random();
                    h[i] = random.Next();
                }

                for (int i = 0; i < h.Length; i++)
                {
                    Console.WriteLine(h[i] + "");
                }

            }*/
        }
    }
}
