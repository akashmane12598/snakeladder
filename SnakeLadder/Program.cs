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
            int dice1 = random.Next(1, 7);
            Console.WriteLine("The number appeared on the die for player1: " +dice1);
        }
    }
}
