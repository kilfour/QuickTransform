using Xunit;

namespace QuickTransform.Tests
{
    public class Foo
    {
        [Fact]
        public void Bar()
        {
            Assert.Equal(42, TheAnswer.ToLifeTheUniverseAndEverything());
        }
    }
}
