using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7_sesdiena_15_02_20
{
    class OjbExample
    {
        private int a = 0;// ja raksta public OjbExample pieskirot int, tad seit 0 nevajag rakstit paliek tikai a
        private int b = 0;

        public OjbExample(int a, int b)// vai (int locaA, int locaB)
        {
            this.a = a;// vai a = localA
            this.b = b;// vai b = localB
        }

        public void setA(int par1)
        {
            a = par1;
        }
        public int getA()
        {
            return a;
        }
        public void setB(int par1)
        {
            b = par1;
        }
        public int getB()
        {
            return b;
        }
        public void print()
        {
        Console.WriteLine("a = " + a + "b = " + b);
        }

    }
}
