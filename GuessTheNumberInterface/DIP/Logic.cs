namespace GuessTheNumberInterface.DIP
{
    internal class Logic
    {
        private bool _lastAnswer = false;
        private IProgram _program2;

        public Logic(IProgram program2)
        {
            _program2 = program2;
        }

        public void YesOrNo()
        {
            _lastAnswer = !_lastAnswer;
            _program2.ShowAnswer( _lastAnswer);
        }
    }
}
