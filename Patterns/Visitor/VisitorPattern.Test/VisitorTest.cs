using System.Text;
using Xunit;

namespace VisitorPattern.Test
{
    public class VisitorTest
    {
        [Fact]
        public void LiteralTest()
        {
            // create a literal expression
            var expression = new Literal(5);

            // create a visitor that will print the expression
            var sb = new StringBuilder();
            var printer = new ExpressionPrinter(sb);

            printer.Visit(expression);
            Assert.Equal("5", sb.ToString());
        }

        [Fact]
        public void SimpleAdditionTest()
        {
            // create addition expression tree
            var expression = new Addition(
                new Literal(5),
                new Literal(10)
            );

            // create a visitor that will print the expression
            var sb = new StringBuilder();
            var printer = new ExpressionPrinter(sb);

            printer.Visit(expression);

            Assert.Equal("(5+10)", sb.ToString());
        }

        [Fact]
        public void NestedAdditionTest()
        {
            var expression = new Addition(
                new Addition(
                    new Literal(2),
                    new Literal(3)
                ),
                new Literal(10)
            );

            var sb = new StringBuilder();
            var printer = new ExpressionPrinter(sb);
            printer.Visit(expression);

            Assert.Equal("((2+3)+10)", sb.ToString());
        }
    }
}