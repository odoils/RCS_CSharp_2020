using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulators_MD_1
{
    class Darbiba
    {
        private static double result = 0;
        private static string input = "0";
        private static string a = "";

        public static void Reset() 
        {
            result = 0;
            a = "";
            input = "0";
        }

        public static void SetOperator(string a)
        {
            Darbiba.a = a;
        }

        public static void SetInput(string input)
        {
            Darbiba.input = input;
        }

        public static string GetInput()
        {
            return input;
        }

        public static string GetResult()
        {
            return result.ToString();
        }

        private static void Add()// saskaitisana
        {
            double numValue = Convert.ToDouble(input);
            result += numValue;
        }

        private static void Subtract()//atnemsana
        {
            double numValue = Convert.ToDouble(input);
            result -= numValue;
        }

        private static void Multiply()// reizinasana
        {
            double numValue = Convert.ToDouble(input);
            result *= numValue;
        }

        private static void Divide()//dalisana
        {
            double numValue = Convert.ToDouble(input);
            if (numValue != 0)
                result /= numValue;
        }

        private static void InputAsResult()
        {
            result = Convert.ToDouble(input);
        }

        public static void DoAritmetics() //matematiskas darbibas
        {
            switch (a)
            {
                case "+":
                    Add();
                    break;
                case "-":

                    Subtract();
                    break;
                case "*":

                    Multiply();
                    break;
                case "/":

                    Divide();
                    break;

                default:

                    InputAsResult();
                    break;
            }
        }
    }
}
