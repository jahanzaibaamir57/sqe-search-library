using Xunit;
using SearchLibrary;

namespace SearchLibrary.Tests
{
    public class LinearSearchStrategyTests
    {
        private readonly LinearSearchStrategy _search = new LinearSearchStrategy();

        [Fact]
        public void Search_NullArray_ReturnsMinusOne()
        {
            int result = _search.Search(null, 10);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Search_EmptyArray_ReturnsMinusOne()
        {
            Order[] orders = new Order[0];
            int result = _search.Search(orders, 10);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Search_TargetFound_ReturnsCorrectIndex()
        {
            Order[] orders =
            {
                new Order(5, "A"),
                new Order(10, "B"),
                new Order(15, "C")
            };

            int result = _search.Search(orders, 10);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Search_TargetNotFound_ReturnsMinusOne()
        {
            Order[] orders =
            {
                new Order(5, "A"),
                new Order(10, "B"),
                new Order(15, "C")
            };

            int result = _search.Search(orders, 20);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Search_TargetAtFirstPosition()
        {
            Order[] orders =
            {
                new Order(7, "A"),
                new Order(8, "B"),
                new Order(9, "C")
            };

            int result = _search.Search(orders, 7);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Search_TargetAtLastPosition()
        {
            Order[] orders =
            {
                new Order(7, "A"),
                new Order(8, "B"),
                new Order(9, "C")
            };

            int result = _search.Search(orders, 9);
            Assert.Equal(2, result);
        }
    }
}