using System;
using System.Xml;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Variables
            int counter = 0;

            Console.WriteLine("Welcome to Snake and Ladder game");
            int pos = 0;
            Console.WriteLine("Start Position of Player 1 = 0");

            while(pos<=100)
            {
                
                Random random = new Random();
                ////Generating value on a dice
                int dice = random.Next(1, 7);
                Console.WriteLine("The number on dice =" + dice);

                ////Asking for option from user
                Console.WriteLine("Enter a number - 1. No play, 2.Ladder, 3.Snake");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        break;
                    case 2:                       
                        pos = pos + dice;
                        ////Checking if position beyond 100
                        if (pos>100)
                        {
                            pos = pos-dice;
                        }
                        break;
                    case 3:
                        pos = pos - dice;
                        break;
                    default: Console.WriteLine("Enter correct option");
                             break;

                }
                if (pos < 0)
                    pos = 0;

                Console.WriteLine("The position of player =" + pos);
                if(pos==100)
                {
                    Console.WriteLine("Game completed");
                    break;
                }

                counter++;
            }
            ////Printing number of moves
            
            Console.WriteLine("Number of moves by player1 =" + counter);


        }
    }
}
