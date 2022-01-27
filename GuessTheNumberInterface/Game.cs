using System;
using System.Collections.Generic;
using System.Linq;

namespace GuessTheNumberInterface
{
    class Game
    {
        private static readonly Random Random = new Random();
        private readonly int _correctNumber;
        private readonly List<Guess> _guesses;
        public Guess[] Guesses => _guesses.ToArray();
        public bool IsSolved => _guesses.Count > 0 && _guesses.Last().Feedback == Feedback.Correct;

        public Game()
        {
            _correctNumber = Random.Next(1, 100);
            _guesses = new List<Guess>();
        }

        public Feedback Guess(int number)
        {
            var feedback =
                number == _correctNumber ? Feedback.Correct :
                number > _correctNumber ? Feedback.TooHigh :
                Feedback.TooLow;
            var guess = new Guess(number, feedback);
            _guesses.Add(guess);
            return feedback;
        }
    }
}
