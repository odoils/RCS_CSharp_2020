using System;
using System.Collections.Generic;
using System.Text;

namespace Day8__objects
{
    public class Spele
    {
        private int random;
        private int wins;

        public Spele()
        {
            wins = 0;
            random = GenerateRandom();
        }

        public int getNumber()
        {
          return random;
        }

        public int newRandom()
        {
            return random;
        }
        public int GenerateRandom() 
        {
            Random random = new Random();
            int number = random.Next(1, 10);
            return number;
        }

    }
}
