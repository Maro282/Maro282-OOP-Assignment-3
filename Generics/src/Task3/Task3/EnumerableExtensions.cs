

namespace Task3;

public static class EnumerableExtensions
{
    public static IEnumerable<T> Page<T>(this IEnumerable<T> source, int pageNumber, int pageSize)
    {
        ArgumentNullException.ThrowIfNull(source, nameof(source));
        if (pageNumber < 1) throw new ArgumentOutOfRangeException(nameof(pageNumber), "Page number starts at 1");
        if (pageSize < 1) throw new ArgumentOutOfRangeException(nameof(pageSize), "Page size must be at least 1");

        int startIndex = (pageNumber - 1) * pageSize;
        int endIndex = startIndex + pageSize; // this will not be included
        int iterator = 0;

        foreach (var item in source)
        {

            if (iterator >= endIndex) yield break;
            if (iterator >= startIndex) yield return item;
            iterator++;
        }



    }


    public static T? FindById<T>(this IEnumerable<T> source, int id) where T : IHasId
    {
        if (source is null) throw new ArgumentNullException(nameof(source));

        foreach (var item in source)
        {
            if (item.Id == id) return item;
        }
        return default;
    }

    public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(this IEnumerable<T> source) where T : IHasId
    {

        if (source is null) throw new ArgumentNullException(nameof(source));

        var dic = new Dictionary<int, T>();
        foreach (var item in source)
        {
            dic.Add(item.Id, item);
        }

        return dic;

    }

}
