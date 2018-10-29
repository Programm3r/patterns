namespace GenericPattern
{
    public class Operation<T> : IOperation<T>
    {
        private T _val1 { get; }
        private T _val2 { get; }

        public Operation(T val1, T val2)
        {
            _val1 = val1;
            _val2 = val2;
        }

        public T Plus()
        {
            return (dynamic)_val1 + (dynamic)_val2;
        }

        public T Minus()
        {
            return (dynamic)_val1 - (dynamic)_val2;
        }
    }
}