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
        [InlineData("example")]
        [InlineData("example")]
        [InlineData("example")]
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
