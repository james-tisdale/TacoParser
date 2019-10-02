using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything
        }

        [Theory]
        [InlineData("34.018008,-86.079099,Taco Bell Attall...")]
        [InlineData("33.470013,-86.816966,Taco Bell Birmingham...")]
        [InlineData("34.784434,-84.771556,Taco Bell Chatswort...")]
        public void ShouldParse(string str)
        {
            // TODO: Complete Should Parse

            //Arrange
            TacoParserTests tacotest = new TacoParserTests();

            // Act
            double actual = tacotest.ShouldParse(str);

            // Assert
            Assert.Equal(actual, expected: );
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ShouldFailParse(string str)
        {
            // TODO: Complete Should Fail Parse
        }
    }
}
