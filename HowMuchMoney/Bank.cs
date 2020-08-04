using System;
using System.Collections.Generic;
using System.Text;

namespace HowMuchMoney
{
    public class Bank
    {
        static string[] coins = { "penny", "nickel", "dime", "quarter" };
        Random rand;

        public Bank()
        {
            rand = new Random();
        }

        public Bank( int RandomSeed )
        {
            rand = new Random(RandomSeed);
        }

        public int CountMyCoins()
        {
            return rand.Next(10, 50);
        }

        public string[] GetCoins( int howMany )
        {
            string[] MyCoins = new string[howMany];

            for (int i = 0; i < howMany; i++)
            {
                MyCoins[i] = coins[rand.Next(0, 4)];
            }

            return MyCoins;
        }

        public double HowMuch( string[] AllTheCoins )
        {
            double total = 0;

            for (int i = 0; i < AllTheCoins.Length; i++)
            {
                if(AllTheCoins[i] == "penny")
                {
                    total += .01;
                }
                if (AllTheCoins[i] == "nickel")
                {
                    total += .05;
                }
                if (AllTheCoins[i] == "dime")
                {
                    total += .10;
                }
                if (AllTheCoins[i] == "quarter")
                {
                    total += .25;
                }
            }

            return total;
        }
    }
}
