namespace SearchLibrary
{
    public class LinearSearchStrategy : ISearchStrategy
    {
        public int Search(Order[] orders, int targetId)
        {
            if (orders == null || orders.Length == 0)
                return -1;

            for (int i = 0; i < orders.Length; i++)
            {
                if (orders[i].OrderId == targetId)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}