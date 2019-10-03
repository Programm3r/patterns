namespace VisitorPattern
{
    public class Addition : IExpression
    {
        public Addition(IExpression left, IExpression right)
        {
            Left = left;
            Right = right;
        }

        internal IExpression Left { get; }
        internal IExpression Right { get; }

        public void Accept(IExpressionVisitor visitor) => visitor.Visit(this);
    }
}