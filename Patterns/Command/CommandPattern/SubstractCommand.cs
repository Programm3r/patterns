namespace CommandPattern
{
    public class SubstractCommand : ICommand
    {
        private readonly ReceiverCalculator _calculator;

        public SubstractCommand(ReceiverCalculator calculator)
        {
            _calculator = calculator;
        }

        public int Execute()
        {
            return _calculator.Substract();
        }
    }
}
