namespace CommandPattern
{
    public class AddCommand : ICommand
    {
        private readonly ReceiverCalculator _receiverCalculator;

        public AddCommand(ReceiverCalculator calculator)
        {
            _receiverCalculator = calculator;
        }

        public int Execute()
        {
            return _receiverCalculator.Add();
        }
    }
}
