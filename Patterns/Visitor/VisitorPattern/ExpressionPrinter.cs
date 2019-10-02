using System.Text;

namespace VisitorPattern
{
    public class ExpressionPrinter : IExpressionVisitor
    {
        private readonly StringBuilder _sb;

        public ExpressionPrinter(StringBuilder sb)
        {
            _sb = sb;
        }

        public void Visit(Literal literal) => _sb.Append(literal.Value);

        public void Visit(Addition addition)
        {
            _sb.Append("(");
            addition.Left.Accept(this);
            _sb.Append("+");
            addition.Right.Accept(this);
            _sb.Append(")");
        }
    }
}