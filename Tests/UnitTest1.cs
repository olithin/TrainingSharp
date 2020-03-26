using TaskDirectory1.Service;
using TaskDirectory1.Strategies;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GetStrategyHandlerTypeReturnTrue()
        {
            var handler = new FileHandlerFactory();
            var strategy = handler.GetInfoFile(@"/resources/2.txt");
            Assert.IsType<TxtFileStrategy>(strategy);
        }
    }
}