using System;
using GuessTheNumberInterface.DIP;

namespace GuessTheNumberInterface
{
    internal class RobotPlayer 
        //: IPlayer
        : Player
    {
        private Game _game;
        private int _min;
        private int _max;

        public RobotPlayer(Game game) : base(game)
        {
            _game = game;
            _min = 1;
            _max = 100;
        }

        public override void Guess()
        {
            var number = (_min + _max) / 2;
            Console.WriteLine($"Tipper {number}");
            //var feedback = _game.Guess(number);
            //Console.WriteLine(feedback.ToString());
            var feedback = GuessAndShow(number, _game);

            if (feedback == Feedback.TooHigh)
            {
                _max = number;
            }
            else if (feedback == Feedback.TooLow)
            {
                _min = number;
            }
        }


        /*
         * Alternativ løsning 
         */
        protected override int GetANumber()
        {
            var number = (_min + _max) / 2;
            Console.WriteLine($"Tipper {number}");
            return number;
        }

        protected override void PostWork(Feedback feedback, int number)
        {
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
