namespace SearchLibrary
{
    public class InterpolationSearchStrategy : ISearchStrategy
    {
        public int Search(Order[] orders, int targetId)
        {
            if (orders == null || orders.Length == 0)
                return -1;

            int low = 0;
            int high = orders.Length - 1;

            while (low <= high &&
                   targetId >= orders[low].OrderId &&
                   targetId <= orders[high].OrderId)
            {
                if (orders[high].OrderId == orders[low].OrderId)
                {
                    if (orders[low].OrderId == targetId)
                        return low;
                    else
                        return -1;
                }

                int pos = low + (int)((double)(high - low) /
                         (orders[high].OrderId - orders[low].OrderId) *
                         (targetId - orders[low].OrderId));

                if (orders[pos].OrderId == targetId)
                {
                    return pos;
                }

                if (orders[pos].OrderId < targetId)
                {
                    low = pos + 1;
                }
                else
                {
                    high = pos - 1;
                }
            }

            return -1;
        }
    }
}