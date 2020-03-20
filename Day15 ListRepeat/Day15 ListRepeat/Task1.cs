using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day15_ListRepeat
{
    class Task1
    {
        //Listu no int tipa elementiem
        //1. izvaditu visus elementus
        //2. pievienotu
        //3. sasummetu visus lista elementus

        //sarakstu jasaglaba un janolasa no faila
        //Write();
        public static void Execute() 
        {
            List<int> SkaitluSaraksts = new List<int>();

            String choice = "";
            Read(SkaitluSaraksts);

            while (choice != "0")
            {
                PrintMenu();
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Print(SkaitluSaraksts);
                        break;

                    case "2":
                        AddElement(SkaitluSaraksts);
                        break;

                    case "3":
                        Sum(SkaitluSaraksts);
                        break;

                    case "0":
                        break;
                    default:
                        Console.WriteLine("Ievadiet 1,2, 3 vai 0");
                        break;
                }
            }
        }
        private static void Print(List<int> ls)

        {
            if (ls.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss");
                return;
            }
            foreach (int el in ls)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
        private static void AddElement(List<int> ls)
        {
            Console.WriteLine("Ievadiet skaitli!");

            try
            {
                int sk = Convert.ToInt32(Console.ReadLine());
                ls.Add(sk);
                Write(ls);
            }
            catch
            {
                Console.WriteLine("Tas nav skaitlis!");
            }
        }
        private static void Sum(List<int> ls)
        {
            int summa = 0;

            if (ls.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss");
                return;
            }

            foreach (int el in ls)
            {
                summa += el; // var ari sadi - summa = summa+el;
            }
            Console.WriteLine(summa);
        }


            private static void PrintMenu()
        {
            Console.WriteLine("1. Izvadit");
            Console.WriteLine("2. Pievienot jaunu");
            Console.WriteLine("3. Sasummet");
            Console.WriteLine("0. Iziet");
        }

        private static void Write(List<int> ls)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\ugis\\Desktop\\Test.txt");

                foreach (int el in ls)
                {
                    sw.WriteLine(el);
                }

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }
        public static void Read(List<int> ls)
        {
            try
            {
                String line;
               
                StreamReader sr = new StreamReader("C:\\Users\\ugis\\Desktop\\Test.txt");           
                line = sr.ReadLine();
               
                while (line != null)
                {
                    int el = Convert.ToInt32(line);
                    ls.Add(el);                
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
