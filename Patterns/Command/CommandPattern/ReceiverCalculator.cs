namespace CommandPattern
{
    public class ReceiverCalculator
    {
        private readonly int _a;
        private readonly int _b;

        public ReceiverCalculator(int a, int b)
        {
            _a = a;
            _b = b;
        }
        public int Add()
        {
            return _a + _b;
        }

        public int Substract()
        {
            return _a - _b;
        }
    }
}
