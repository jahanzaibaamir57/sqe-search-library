using Xunit;
using SearchLibrary;

namespace SearchLibrary.Tests
{
    public class InterpolationSearchStrategyTests
    {
        private readonly InterpolationSearchStrategy _search = new InterpolationSearchStrategy();

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
                new Order(10, "A"),
                new Order(20, "B"),
                new Order(30, "C"),
                new Order(40, "D")
            };

            int result = _search.Search(orders, 30);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Search_TargetNotFound_ReturnsMinusOne()
        {
            Order[] orders =
            {
                new Order(10, "A"),
                new Order(20, "B"),
                new Order(30, "C")
            };

            int result = _search.Search(orders, 25);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Search_TargetBelowRange_ReturnsMinusOne()
        {
            Order[] orders =
            {
                new Order(100, "A"),
                new Order(200, "B"),
                new Order(300, "C")
            };

            int result = _search.Search(orders, 50);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Search_TargetAboveRange_ReturnsMinusOne()
        {
            Order[] orders =
            {
                new Order(100, "A"),
                new Order(200, "B"),
                new Order(300, "C")
            };

            int result = _search.Search(orders, 400);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Search_AllElementsEqual_TargetFound()
        {
            Order[] orders =
            {
                new Order(50, "A"),
                new Order(50, "B"),
                new Order(50, "C")
            };

            int result = _search.Search(orders, 50);
            Assert.Equal(0, result);
        }
    }
}