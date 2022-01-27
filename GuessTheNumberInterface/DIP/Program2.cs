using System;

namespace GuessTheNumberInterface.DIP
{
    internal class Program2 : IProgram
    {
        public static void Run()
        {
            var program2 = new Program2();
            program2.RunImpl();
        }

        public void RunImpl()
        {
            var logic = new Logic(this);
            while (true)
            {
                logic.YesOrNo();
            }
        }

        public void ShowAnswer(bool answer)
        {
            Console.WriteLine(answer);
        }
    }
}
