using Xunit;
using SearchLibrary;

namespace SearchLibrary.Tests
{
    public class BinarySearchStrategyTests
    {
        private readonly BinarySearchStrategy _search = new BinarySearchStrategy();

        [Fact]
        public void Search_NullArray_ReturnsMinusOne()
        {
            int result = _search.Search(null, 5);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Search_EmptyArray_ReturnsMinusOne()
        {
            Order[] orders = new Order[0];
            int result = _search.Search(orders, 5);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Search_TargetFound_ReturnsCorrectIndex()
        {
            Order[] orders =
            {
                new Order(1, "A"),
                new Order(3, "B"),
                new Order(5, "C"),
                new Order(7, "D")
            };

            int result = _search.Search(orders, 5);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Search_TargetNotFound_ReturnsMinusOne()
        {
            Order[] orders =
            {
                new Order(1, "A"),
                new Order(3, "B"),
                new Order(5, "C")
            };

            int result = _search.Search(orders, 4);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Search_TargetAtFirstPosition()
        {
            Order[] orders =
            {
                new Order(2, "A"),
                new Order(4, "B"),
                new Order(6, "C")
            };

            int result = _search.Search(orders, 2);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Search_TargetAtLastPosition()
        {
            Order[] orders =
            {
                new Order(2, "A"),
                new Order(4, "B"),
                new Order(6, "C")
            };

            int result = _search.Search(orders, 6);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Search_TargetSmallerThanAll_ReturnsMinusOne()
        {
            Order[] orders =
            {
                new Order(10, "A"),
                new Order(20, "B"),
                new Order(30, "C")
            };

            int result = _search.Search(orders, 5);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Search_TargetGreaterThanAll_ReturnsMinusOne()
        {
            Order[] orders =
            {
                new Order(10, "A"),
                new Order(20, "B"),
                new Order(30, "C")
            };

            int result = _search.Search(orders, 40);
            Assert.Equal(-1, result);
        }
    }
}