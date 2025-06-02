
namespace ComputerComponentShop.Models.Services
{
    public interface IListManager<T>
    {
        int Count { get; }

        bool Add(T aItem);
        void DeleteAll();
        void Remove(T aItem);
        void Sort(IComparer<T> sComparer);
        List<T> ToList();
        string[] ToStringArray();
    }
}