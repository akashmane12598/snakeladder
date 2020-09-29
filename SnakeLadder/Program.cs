using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Problem");
            Console.WriteLine("For Single Player");
            int pos1 = 0;

            Random random = new Random();
            int dice1;

            const int no_play = 0;
            const int ladder = 1;
            const int snake = 2;
            const int winning_pos = 100;
            int attempt1 = 0;
            int mov1;

            while (pos1 < winning_pos)
            {
                dice1 = random.Next(1, 7);
                mov1 = random.Next(0, 3);
                Console.WriteLine("The number appeared on the die for player1: " + dice1);
                if (mov1 == ladder)
                {
                    Console.WriteLine("Player1 gets a Ladder");
                    pos1 += dice1;
                    attempt1++;
                    if(pos1 <= winning_pos)
                    {
                        Console.WriteLine("Current position of Player1 in "+attempt1+" attempts: " + pos1);
                    }
                    while (pos1 > winning_pos)
                    {
                        if (pos1 > winning_pos)
                        {
                            pos1 -= winning_pos - dice1;
                        }
                        int a = random.Next(1, 7);
                        int lad1 = random.Next(0, 3);
                        if (a == winning_pos - pos1 && lad1 == ladder)
                        {
                            pos1 += a;
                        }
                        Console.WriteLine("The number appeared on the die for player1: " + dice1);
                        Console.WriteLine("Current position of Player1 in " + attempt1 + " attempts: " + pos1);
                        attempt1++;
                    }
                }
                else if (mov1 == snake)
                {
                    Console.WriteLine("Player1 gets a Snake");
                    pos1 -= dice1;
                    if (pos1 < 0)
                    {
                        pos1 = 0;
                    }
                    attempt1++;
                    Console.WriteLine("Current position of Player1 in " + attempt1 + " attempts: " + pos1);
                }
                else
                {
                    Console.WriteLine("Player1 gets a No-Play");
                    attempt1++;
                    Console.WriteLine("Current position of Player1 in " + attempt1 + " attempts: " + pos1);
                }

            }
            
            Console.WriteLine("Position of player1 after "+attempt1+" attempts: "+pos1);
        }
    }
}
