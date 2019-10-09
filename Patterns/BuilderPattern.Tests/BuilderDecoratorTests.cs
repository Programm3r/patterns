using FluentAssertions;
using Xunit;

namespace BuilderPattern.Tests
{
    public class BuilderDecoratorTests
    {
        [Fact]
        public void WhenItalianMenuIsBuild_ItShouldContainOnlyItalianItems()
        {
            //ARRAGE
            var sut = new ItalianMenuBuilder();
            var director = new Director();

            //ACT
            director.BuildMenu(sut);
            var result = sut.GetMenu();

            //ASSERT
            result.Items.Should().Contain("Spaghetti");
            result.Items.Should().Contain("Lambrusco");
            result.Items.Should().Contain("Tiramisu");

            result.Items.Should().NotContain("Ice cream");
            result.Items.Should().NotContain("Coke");
            result.Items.Should().NotContain("Cheeseburger");

            result.Items.Count.Should().Be(3);
        }

        [Fact]
        public void WhenFastFoodMenuIsBuild_ItShouldContainOnlyFastFoodItems()
        {
            //ARRAGE
            var sut = new FastFoodMenuBuilder();
            var director = new Director();

            //ACT
            director.BuildMenu(sut);
            var result = sut.GetMenu();

            //ASSERT
            result.Items.Should().Contain("Ice cream");
            result.Items.Should().Contain("Coke");
            result.Items.Should().Contain("Cheeseburger");   
            
            result.Items.Should().NotContain("Spaghetti");
            result.Items.Should().NotContain("Lambrusco");
            result.Items.Should().NotContain("Tiramisu");

            result.Items.Count.Should().Be(3);
        }
    }
}
