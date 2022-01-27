using System;
using GuessTheNumberInterface.DIP;

namespace GuessTheNumberInterface
{
    internal class HumanPlayer 
        //: IPlayer
        : Player
    {
        public HumanPlayer(Game game) : base(game)
        {
        }

        public override void Guess()
        {
            Console.Write("Tipp et tall: ");
            var number = Convert.ToInt32(Console.ReadLine());
            //var feedback = _game.Guess(number);
            //Console.WriteLine(feedback.ToString());
            GuessAndShow(number, _game);
        }

        /*
          * Alternativ løsning 
          */

        protected override int GetANumber()
        {
            Console.Write("Tipp et tall: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
