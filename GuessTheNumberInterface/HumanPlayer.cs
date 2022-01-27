using System;

namespace GuessTheNumberInterface
{
    internal class HumanPlayer : IPlayer
    {
        private Game _game;

        public HumanPlayer(Game game)
        {
            _game = game;
        }

        public void Guess()
        {
            Console.Write("Tipp et tall: ");
            var number = Convert.ToInt32(Console.ReadLine());
            var feedback = _game.Guess(number);
            Console.WriteLine(feedback.ToString());
        }
    }
}
