using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberInterface
{
    internal class RobotPlayer : IPlayer
    {
        private Game _game;
        private int _min;
        private int _max;

        public RobotPlayer(Game game)
        {
            _game = game;
            _min = 1;
            _max = 100;
        }

        public void Guess()
        {
            var number = (_min + _max) / 2;
            Console.WriteLine($"Tipper {number}");
            var feedback = _game.Guess(number);
            Console.WriteLine(feedback.ToString());

            if (feedback == Feedback.TooHigh)
            {
                _max = number;
            }
            else if (feedback == Feedback.TooLow)
            {
                _min = number;
            }
        }
    }
}
