using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Problem");
            Console.WriteLine("For Two Players");
            int pos1 = 0;
            int pos2 = 0;

            Random random = new Random();
            int dice1=0;
            int dice2=0;

            const int no_play = 0;
            const int ladder = 1;
            const int snake = 2;
            const int winning_pos = 100;
            int attempt1 = 0;
            int attempt2 = 0;
            int mov1=0;
            int mov2=0;
            Boolean flag1 = false;
            Boolean flag2 = false;

            player1: while (pos1 < winning_pos)
            {
                dice1 = random.Next(1, 7);
                mov1 = random.Next(0, 3);

                Console.WriteLine("The number appeared on the die for player1: " + dice1);
                if (mov1 == ladder)
                {
                    Console.WriteLine("Player1 gets a Ladder");
                    int c = 0;   //for ladder chance count
                    while (c < 2) 
                    { 
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
                        c++;
                    }
                    if (pos1 == winning_pos)
                    {
                        flag1=true;
                        goto end;
                    }
                    else
                    {
                        goto player2;
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
                    goto player2;
                }
                else
                {
                    Console.WriteLine("Player1 gets a No-Play");
                    attempt1++;
                    Console.WriteLine("Current position of Player1 in " + attempt1 + " attempts: " + pos1);
                    goto player2;
                }

            }
            
            Console.WriteLine("Position of player1 after "+attempt1+" attempts: "+pos1);


          player2:  while (pos2 < winning_pos)
            {
                dice2 = random.Next(1, 7);
                mov2 = random.Next(0, 3);

                Console.WriteLine("The number appeared on the die for player2: " + dice2);
                if (mov2 == ladder)
                {
                    Console.WriteLine("Player2 gets a Ladder");
                    int c = 0;
                    while (c < 2)
                    {
                        pos2 += dice2;
                        attempt2++;
                        if (pos2 <= winning_pos)
                        {
                            Console.WriteLine("Current position of Player2 in " + attempt2 + " attempts: " + pos2);
                        }
                        while (pos2 > winning_pos)
                        {
                            if (pos2 > winning_pos)
                            {
                                pos2 -= winning_pos - dice2;
                            }
                            int a = random.Next(1, 7);
                            int lad1 = random.Next(0, 3);
                            if (a == winning_pos - pos2 && lad1 == ladder)
                            {
                                pos2 += a;
                            }
                            Console.WriteLine("The number appeared on the die for player2: " + dice2);
                            Console.WriteLine("Current position of Player2 in " + attempt2 + " attempts: " + pos2);
                            attempt2++;
                            
                        }
                        c++;
                    }
                    if (pos2 == winning_pos)
                    {
                        flag2 = true;
                        goto end;
                    }
                    else
                    {
                        goto player1;
                    }
                }
                else if (mov2 == snake)
                {
                    Console.WriteLine("Player2 gets a Snake");
                    pos2 -= dice2;
                    if (pos2 < 0)
                    {
                        pos2 = 0;
                    }
                    attempt2++;
                    Console.WriteLine("Current position of Player2 in " + attempt2 + " attempts: " + pos2);
                    goto player1;
                }
                else
                {
                    Console.WriteLine("Player2 gets a No-Play");
                    attempt2++;
                    Console.WriteLine("Current position of Player2 in " + attempt2 + " attempts: " + pos2);
                    goto player1;
                }

            }

            Console.WriteLine("Position of player2 after " + attempt2 + " attempts: " + pos2);

            Console.WriteLine();

           end: if (flag1==true)
            {
                Console.WriteLine("Player1 wins the game");
            }
            else
            {
                Console.WriteLine("Player2 wins the game");
            }

        }
    }
}
