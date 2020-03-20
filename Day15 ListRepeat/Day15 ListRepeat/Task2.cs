using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day15_ListRepeat
{
    class Task2 
    {
        //Atvert failu, kur stav skaitli
        //1
        //5
        //7

        //Cilveks ievada skaitli
        //Uzrakstat uz ekrana cik reizes skaitlis ir bijis failaa

        public static void Execute()
        {
            Console.WriteLine("Ievadiet skaitli!");
            List<int> numbers = new List<int>();
            Read(numbers);

            try
            {
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Saraksta skaitlis ir " + ReturnCount(numbers, skaitlis) + " reizes");
            }
            catch
            {
                Console.WriteLine("Sis nav skaitlis!");
            }
        }
        private static void Read(List<int> ls)
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
        private static int ReturnCount(List<int> ls, int number)
        {
            int result = 0;
            foreach (int el in ls)
            {
                if (el == number)
                {
                    result++;
                }
            }
            return result;
        }
    }
}

