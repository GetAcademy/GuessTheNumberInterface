using System;
using GuessTheNumberInterface;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            var player = new HumanPlayer(game);
            player.Play();
        }
    }
}
