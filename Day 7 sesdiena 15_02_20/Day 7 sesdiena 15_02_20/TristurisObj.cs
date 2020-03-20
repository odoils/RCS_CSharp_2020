using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7_sesdiena_15_02_20
{
    class TristurisObj
    {
        private int mala1;
        private int mala2;
        private int mala3;
        public TristurisObj(int mala1, int mala2, int mala3)
        {
            this.mala1 = mala1;
            this.mala2 = mala2;
            this.mala3 = mala3;
        }

        public void setMala1(int par1)
        {
            mala1 = par1;
        }
        public int getMala1()
        {
            return mala1;
        }

        public void setMala2(int par1)
        {
            mala2 = par1;
        }
        public int getMala2()
        {
            return mala2;
        }

        public void setMala3(int par1)
        {
            mala3 = par1;
        }
        public int getMala3()
        {
            return mala3;
        }
        public void print()
        {
            int p = 0;
            if (mala1 > 0 && mala2 > 0 && mala3 > 0)
            {
                p = mala1 + mala2 + mala3;
            }
            Console.WriteLine("Perimetrs ir " + p);

        }
    }
}
