using System;

namespace SpeleKaratavas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadiet minamo vardu: ");
            string vards = Console.ReadLine();
            Console.Clear();

            int kluda = 0;
            int maxKluda = 5;
            int izdevas = 0;

            char[] rezultats = new char[vards.Length];
            for (int i = 0; i < rezultats.Length; i++)
            {
                rezultats[i] = '-';
            }

            do
            {
                Console.Write("Ievadiet burtu: ");
                char tryLetter = Convert.ToChar(Console.ReadLine());
                int[] indexes = new int[vards.Length];
                bool found = false;

                for (int i = 0; i < vards.Length; i++)
                {
                    if (vards[i] == tryLetter)
                    {
                        rezultats[i] = tryLetter;
                        izdevas++;
                        found = true;
                    }
                }

                if (!found)
                {
                    kluda++;
                }

                Console.WriteLine(rezultats);

                Console.WriteLine("Pielautas " + kluda + " kludas no " + maxKluda);

            } while (kluda < maxKluda && izdevas < vards.Length);

            if (kluda < maxKluda)
            {
                Console.WriteLine("Apseveicam, Tu uzmineji vardu");
            }
            else
            {
                Console.WriteLine("Diemzel Tev neizdevas uzminet vardu");
            }
        }
    }    
}
