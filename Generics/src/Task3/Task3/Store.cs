

namespace Task3;

public class Store<T> where T : class, IHasId
{

    private readonly Dictionary<int, T> _collection = new();


    public void Add(T obj)
    {
        ArgumentNullException.ThrowIfNull(obj);

        if (!_collection.TryAdd(obj.Id, obj))
            throw new ArgumentException($"An object with Id {obj.Id} already exists.", nameof(obj));
    }



    public T? GetById(int id)
    {


        if (!_collection.TryGetValue(id, out T obj))
        {
            return null;
        }
        else
        {
            return obj;
        }

    }


    public IReadOnlyDictionary<int, T> GetAll() => _collection;

    public void Remove(int id)
    {

        if (!_collection.TryGetValue(id, out T obj))
        {
            throw new ArgumentOutOfRangeException("Id not foud");
        }
        else
        {
            _collection.Remove(id);
        }

    }

}
