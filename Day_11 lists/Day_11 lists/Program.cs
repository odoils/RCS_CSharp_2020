using System;

namespace Day_11_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzd4();        
        }

        static void Uzd4()
        {
            //While loop menu (metodi izmantojam kalkulatoraa)
            //1.Izvadit informaciju
            // ja saraksts ir tukss, tad ari pasakam
            //2.pievienot jaunu sarakstu
            // ja vairs nav vietas tad ari pasakam
            //3.Rediget ierakstu
            // izvelas ko rediget
            //4. Iziet
            //5. Vietas

            /*if (a[0] == null) //parbauda vai ir izsaukts new
             {

             }*/

            students[] a = new students[5];
            String choice = "";

            while (choice != "0")
            {
                PrintMenu();
                choice = Console.ReadLine();

                switch (choice) 
                {
                    case "1":
                        PrintStudent(students);
                        break;
                    case "2":
                        AddStudent(students);
                        break;
                    case "3":
                        EditStudent(students);
                        break;
                    case "0":
                        break;
                    dafault:
                        Console.WriteLine("Ievadiet 1,2,3 vai 0");
                        break;                
                }
            
            
            }
            static void PrintMenu()
            {
                Console.WriteLine("1. Izvadit");
                Console.WriteLine("2. Pievienot jaunu studentu");
                Console.WriteLine("3. Rediget informaciju");
                Console.WriteLine("0. Iziet");
            }
            static void PrintStudent(students [] st)
            {
                if (st[0] == null)
                {
                    Console.WriteLine("Saraksts ir tukss");
                }
                else 
                {
                    for (int i = 0; i < st.Length; i++) 
                    {
                        if(st[i] == null) 
                        {
                            break;
                        }
                        Console.Write(i + 1 + ")");
                        st[i].print();
                    }

                }
            }
            static void AddStudent(students[] st)
            {
                bool full = false;
                for (int i = 0; i < st.Length; i++) 
                {
                    if (st[i] == null) 
                    {
                        Console.WriteLine("Ievadiet vardu");
                        String name = Console.ReadLine();

                        Console.WriteLine("Ievadiet uzvardu");
                        String surname = Console.ReadLine();

                        Console.WriteLine("Ievadiet kursu");
                        int course = Convert.ToInt32(Console.ReadLine());

                        st[i] = new students(name, surname, course);
                        break;
                    }
                    if (i == st.Length - 1) 
                    {
                        full = true;
                    }
                }
                if (full) // sis ir taspats kas (full == true)
                {
                    Console.WriteLine("Masivs ir pilns");
                }
            }
            static void EditStudent(students[] st)
            {
                PrintStudent(st);
                Console.WriteLine("Kuru ierakstu velaties rediget");               
                int index = Convert.ToInt32(Console.ReadLine());

                if (index - 1 >st.Length-1 || index - 1 < 0 || st[index - 1] == null)// svarigi ir seciba ka ieliek
                {
                    Console.WriteLine("Tads ieraksts neeksiste");
                    return;
                }
                Console.WriteLine("ko velaties rediget");
                Console.WriteLine("1. Vards");
                Console.WriteLine("2. Uzvards");
                Console.WriteLine("3. Kurss");

                String choice = Console.ReadLine();
                
                switch (choice) 
                {
                    case "1":
                        Console.WriteLine("Ievadiet vardu!");
                        st[index -1].setName(Console.ReadLine());
                        break;
                    case "2":
                        Console.WriteLine("Ievadiet uzvardu!");
                        st[index - 1].setSurname(Console.ReadLine());
                        break;
                    case "3":
                        Console.WriteLine("Ievadiet kursu!");
                        st[index - 1].setCourse(Convert.ToInt32(Console.ReadLine()));
                        break;
                    default:
                        Console.WriteLine("Tads lauks neeksiste");
                        break;


                }

            }

        }
            
            
        static void Uzd3()
        {
                //students st1 = new students("Janis", "Barzins", 2);


                //klasei students pievienot SetMetodes
                //Uztaisit masivu ar 5 elementiem
                // Students
                //Cikla masivu aizpilda cilveks
                // Informaciju par visiem cilvekiem izvada

                students[] a = new students[5];

                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine("Ievadiet vardu");
                    String name = Console.ReadLine();

                    Console.WriteLine("Ievadiet uzvardu");
                    String surname = Console.ReadLine();

                    Console.WriteLine("Ievadiet kursu");
                    int course = Convert.ToInt32(Console.ReadLine());

                    a[i] = new students(name, surname, course);

                }
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine(a[i].GetName() + "" + a[i].GetSurname() + "" + a[i].GetCourse());

                }

        }
        
    }
}
