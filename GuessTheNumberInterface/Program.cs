using System;

namespace GuessTheNumberInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Vil du spille selv (j/n)? ");
                var answer = Console.ReadLine();
                var game = new Game();
                IPlayer player;
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
