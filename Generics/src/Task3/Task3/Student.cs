

namespace Task3;

public class Student
{

    public int Id { get; }

    public string Name { get; }

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }
}


public class StudentStore
{

    private readonly List<Student> _students = new();

    public IReadOnlyList<Student> Students { get { return _students; } }


    public void Add(Student student)
    {
        _students.Add(student);
    }

    public Student? GetById(int id)
    {

        foreach (var student in _students)
        {
            if (student.Id == id) return student;
        }

        return null;
    }

    public IReadOnlyList<Student> GetAll() => _students;


    public void Remove(int id)
    {
        var student = GetById(id);
        if (student == null) throw new ArgumentNullException("Id not fount");
        _students.Remove(student);
    }


}
