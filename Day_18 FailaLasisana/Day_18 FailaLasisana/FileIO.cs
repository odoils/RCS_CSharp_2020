using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_18_FailaLasisana
{
    class FileIO
    {
        private static string errorMessage;

        public static string GetErrorMessage()
        {
            return errorMessage;
        }

        public static List<string> LoadFromFile()
        {
            String line;
            List<string> Test = new List<string>();

            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\ugis\\Desktop\\Test.txt");
                line = sr.ReadLine();

                while (line != null && line != "")
                {
                    Test.Add(line);
                    line = sr.ReadLine();
                }

                sr.Close();
                return Test;

            }
            catch (Exception e)
            {
                errorMessage += e.Message + "";
                return null;
            }
        }
    }
}
