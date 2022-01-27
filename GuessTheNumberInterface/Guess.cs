namespace GuessTheNumberInterface
{
    class Guess
    {
        public int Number { get; }
        public Feedback Feedback { get; }

        public Guess(int number, Feedback feedback)
        {
            Number = number;
            Feedback = feedback;
        }
    }
}
