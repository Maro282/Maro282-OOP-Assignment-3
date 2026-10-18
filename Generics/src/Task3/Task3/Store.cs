

namespace Task3;

public class Store<T>
{

    private readonly List<T> _items = new();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public T? GetById(int id)
    {
        foreach (var item in _items)
        {
            if (item.Id == id) return item; // does not compile
        }

        return null; // does not compile

    }

    public IReadOnlyList<T> GetAll() => _items;



    public void Remove(int id)
    {
        var item = GetById(id);
        if (item == null) throw new ArgumentNullException("Id not fount");
        _items.Remove(item);
        Console.WriteLine("Deleted successfully");
    }
}
