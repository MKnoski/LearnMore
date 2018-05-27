using FluentAssertions;
using LearnMore.Api.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LearnMore.Api.UnitTests
{
    [TestClass]
    public class ValuesControllerTests
    {
        private ValuesController sut;

        [TestInitialize]
        public void Init()
        {
            this.sut = new ValuesController();
        }

        [TestMethod]
        public void Get_ShouldReturnValues()
        {
            // Act
            var result = this.sut.Get();

            // Assert
            result[0].Should().Be("value1");
            result[1].Should().Be("value2");
        }
    }
}
