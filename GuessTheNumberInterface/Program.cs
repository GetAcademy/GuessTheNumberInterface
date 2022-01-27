using System;
using GuessTheNumberInterface;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            while (!game.IsSolved)
            {
                Console.Write("Tipp et tall: ");
                var number = Convert.ToInt32(Console.ReadLine());
                var feedback = game.Guess(number);
                Console.WriteLine(feedback.ToString());
            }
        }
    }
}
