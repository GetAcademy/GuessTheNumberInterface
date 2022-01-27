using System;

namespace GuessTheNumberInterface.DIP
{
    internal abstract class Player
    {
        protected Game _game;

        public Player(Game game)
        {
            _game = game;
        }

        public virtual void Guess()
        {
        }

        //public void ShowStars()
        //{
        //    Console.WriteLine("*******************");
        //}

        public Feedback GuessAndShow(int number, Game game)
        {
            var feedback = game.Guess(number);
            Console.WriteLine(feedback.ToString());
            return feedback;
        }

        /*
         * Alternativ løsning 
         */
        public void Guess2()
        {
            var number = GetANumber();
            var feedback = _game.Guess(number);
            Console.WriteLine(feedback.ToString());
            PostWork(feedback, number);
        }

        protected virtual void PostWork(Feedback feedback, int number)
        {
        }

        protected abstract int GetANumber();
    }
}
