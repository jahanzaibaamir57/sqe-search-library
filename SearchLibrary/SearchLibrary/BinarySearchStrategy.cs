using System;

namespace SearchLibrary
{
    public class BinarySearchStrategy : ISearchStrategy
    {
        public int Search(Order[] orders, int targetId)
        {
            if (orders == null || orders.Length == 0)
                return -1;

            int left = 0;
            int right = orders.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (orders[mid].OrderId == targetId)
                {
                    return mid;
                }
                else if (orders[mid].OrderId < targetId)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}