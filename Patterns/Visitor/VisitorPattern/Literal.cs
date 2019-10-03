namespace VisitorPattern
{
    public class Literal : IExpression
    {
        public Literal(double value)
        {
            Value = value;
        }

        internal double Value { get; }

        public void Accept(IExpressionVisitor visitor) => visitor.Visit(this);
    }
}