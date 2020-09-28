using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder game");
            int pos = 0;
            Console.WriteLine("Start Position of Player 1 = 0");

            Random random = new Random();
            ////Generating value on a dice
            int dice = random.Next(1, 7);
            Console.WriteLine("The number on dice =" + dice );

        }
    }
}
