namespace VisitorPattern
{
    public interface IExpression
    {
        void Accept(IExpressionVisitor visitor);
    }
}