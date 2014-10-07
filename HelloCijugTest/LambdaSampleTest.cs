namespace HelloCijugTest
{
    using System.Collections.Generic;
    using System.Linq;

    using HelloCijug;

    using Moq;

    using Xunit;

    public class LambdaSampleTest
    {
        private Mock<IMathOperator> sample;

        private MathOperations operations;

        public LambdaSampleTest()
        {
            sample = new Mock<IMathOperator>();

            operations = new MathOperations(new List<IMathOperator> { sample.Object });
        }

        [Fact]
        public void ShouldMockUsingLambdas()
        {
            sample.Setup(mock => mock.PerformOperation(1, 2)).Returns(-1);

            var results = operations.PerformAll(1, 2);

            Assert.Equal(-1, results.First());
        }
    }
}