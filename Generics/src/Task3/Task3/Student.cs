

namespace Task3;

public class Student : IHasId
{

    public int Id { get; }

    public string Name { get; }

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }
}


