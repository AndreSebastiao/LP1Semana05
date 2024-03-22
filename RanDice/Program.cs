using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get bock the number of dies and seed
            int n = int.Parse(args[0]);
            int s = int.Parse(args[1]);

            //Random generation based on the seed provided
            Random random = new Random(s);

            //Declaring variable
            int diceResult = 0;

            //Loop to add the number from the dies
            for(int i = 0;i < n; i++)
            {
                //Random number between 1-6
                int randomNumber = random.Next(1, 7);

                //Add result to the final product
                diceResult += randomNumber;

                //Reset the value of the dice
                randomNumber = 0;
            }
            Console.WriteLine(diceResult);
        }
    }
}
