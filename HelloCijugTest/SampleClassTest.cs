namespace HelloCijugTest
{
    using HelloCijug;
    using HelloCijug.Sample;

    using Xunit;

    public class SampleClassTest
    {
        [Fact]
        public void ShouldAddTwoNumbers()
        {
            Assert.Equal(3, SampleClass.Add(1, 2));
        }
    }
}
