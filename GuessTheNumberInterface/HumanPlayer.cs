using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessTheNumber;

namespace GuessTheNumberInterface
{
    internal class HumanPlayer
    {
        private Game _game;

        public HumanPlayer(Game game)
        {
            _game = game;
        }

        public void Play()
        {
            while (!_game.IsSolved)
            {
                Console.Write("Tipp et tall: ");
                var number = Convert.ToInt32(Console.ReadLine());
                var feedback = _game.Guess(number);
                Console.WriteLine(feedback.ToString());
            }

        }
    }
}
