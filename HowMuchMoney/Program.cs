using System;

namespace HowMuchMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank MyBank = new Bank( 73 );
            int numOfCoins = MyBank.CountMyCoins();

            Console.WriteLine($"Wow! I have {numOfCoins} coins in my bank!\n");

            string[] AllMyCoins = MyBank.GetCoins(numOfCoins);
            double howMuch = MyBank.HowMuch(AllMyCoins);
            Console.WriteLine($"I have ${Math.Round(howMuch)}\n");
        }
    }
}
