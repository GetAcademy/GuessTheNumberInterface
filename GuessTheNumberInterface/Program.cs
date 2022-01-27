using System;
using GuessTheNumberInterface.DIP;

namespace GuessTheNumberInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program2.Run();
            //return;

            while (true)
            {
                Console.Write("Vil du spille selv (j/n)? ");
                var answer = Console.ReadLine();
                var game = new Game();
                Player player;
                if (answer == "j")
                {
                    player = new HumanPlayer(game);
                }
                else
                {
                    player = new RobotPlayer(game);
                }
                while (!game.IsSolved)
                {
                    player.Guess();
                }
            }
        }
    }
}
