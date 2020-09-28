using System;
using System.Xml;

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

            ////Asking for option from user
            Console.WriteLine("Enter a number - 1. No play, 2.Ladder, 3.Snake");
            int option = Console.Read();
            switch(option)
            {
                case 1: pos = dice;
                        break;
                case 2: pos = pos + dice;
                        break;
                case 3: pos = pos - dice;
                        break;
                default: break;
            }


        }
    }
}
