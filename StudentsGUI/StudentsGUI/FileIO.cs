using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace StudentsGUI
{
    class FileIO
    {
        private static string errorMessage = "";
        private static string path = "";

        public static string GetErrorMessage()
        {
            return errorMessage;
        }
        public static string GetPath()
        {
            return path;
        }
        public static void SetPath(string path)
        {
            FileIO.path = path;
        }
        public static List<Students> LoadFromFile()
        {
            String line;
            List<Students> students = new List<Students>();
            try
            {
                StreamReader sr = new StreamReader(path);
                line = sr.ReadLine();
                List<string> fields = new List<string>();

                while (line != null && line != "")
                {
                    fields = line.Split(' ').ToList();
                    Students student = new Students(fields[0], fields[1], Convert.ToInt32(fields[2]));

                    students.Add(student);
                    line = sr.ReadLine();
                }
                sr.Close();
                return students;
            }
            catch (Exception e)
            {
                errorMessage += e.Message + "";
                return null;
            }
        }
        public static bool WriteToFile(List<Students> students)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path);

                foreach (Students student in students)
                {
                    sw.WriteLine(String.Format(
                        "{0} {1} {2}",
                        student.GetName(),
                        student.GetSurname(),
                        student.GetCourse()
                    ));
                }

                sw.Close();
                return true;
            }
            catch (Exception e)
            {
                errorMessage += e.Message + "";
                return false;
            }
        }
    }
}
