using System;
using System.Collections.Generic;
using System.Text;

namespace Day8__objects
{
    class Rinkis
    {
        private double R;
        public Rinkis( double R) // sis ir konstruktors
        {
            this.R = R;          
        }
        public void print()
        {
            double S = 0;// so var izlikt ari ka privat bouble atstajot Console zem print
            S = (3.14 * R*R);// 3.14 vieta var likt Math.PI

            Console.WriteLine ("laukums ir " + S);           
        }
        public void print2()
        {
            Console.WriteLine("Radius ir " + R);
        }
    }
}
