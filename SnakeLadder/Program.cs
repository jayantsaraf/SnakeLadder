using System;
using System.Xml;

namespace SnakeLadder
{
    class Program
    {
        static int RollDice()
        {
            Random random = new Random();
            ////Generating value on a dice
            int dice = random.Next(1, 7);
            Console.WriteLine("The number on dice =" + dice);
            return dice;
        }
        static int Play(int p,int dice,int playernumber)
        {
            int player = playernumber;
            Random random = new Random();
            int option = random.Next(1, 4); ////Generating options for 1. No Play, 2.Ladder, 3.Snake
            switch (option)
            {
                case 1:
                    break;
                case 2:
                    p = p + dice;                   
                    ////Checking if position beyond 100
                    if (p > 100)
                    {
                        p = p - dice;
                    }
                    Console.WriteLine("Player " + player + "plays again");
                    int DiceOption = random.Next(1, 7);
                    p = Play(p, DiceOption, player);
                    break;
                case 3:
                    p = p - dice;
                    break;
                default:
                    break;
            }
            return p;
        }
        static void Main(string[] args)
        {
            ////Variables
            int counter = 0;

            Console.WriteLine("Welcome to Snake and Ladder game");
            int pos = 0;////player 1 position
            int pos2 = 0;////player 2 position
            Console.WriteLine("Start Position of Player 1 = 0");
            Console.WriteLine("Start Position of Player 2 = 0");

            while (pos <= 100 || pos2 <= 100)
            {
                ////Working for Player 1
                int dice = RollDice();
                
                Console.WriteLine("Player 1 play");
                pos = Play(pos, dice,1);    
                
                if (pos < 0)
                    pos = 0;
                Console.WriteLine("The position of player 1 =" + pos);
                if (pos == 100)
                {
                    Console.WriteLine("Game completed. Player 1 won");
                    break;
                }

                ////Working for player 2
                dice = RollDice();
                Console.WriteLine("Player 2 play");
                pos2 = Play(pos2, dice,2);
                if (pos2 < 0)
                    pos2 = 0;

                Console.WriteLine("The position of player 2 =" + pos2);
                if (pos2 == 100)
                {
                    Console.WriteLine("Game completed. Player 2 won");
                    break;
                }
            }
        }
        }
    }
