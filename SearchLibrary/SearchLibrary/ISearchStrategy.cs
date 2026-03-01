namespace SearchLibrary
{
    public interface ISearchStrategy
    {
        int Search(Order[] orders, int targetId);
    }
}