namespace VisitorPattern
{
    public interface IExpressionVisitor
    {
        void Visit(Literal literal);
        void Visit(Addition addition);
    }
}