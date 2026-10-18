

namespace Task3;

public class Course
{
    public int Id { get; }
    public string Title { get; }
    public decimal Price { get; private set; }

    public Course(int id, string title, decimal price)
    {
        Id = id;
        Title = title;
        Price = price;
    }

}



public class CourseStore
{
    private readonly List<Course> _courses = new();

    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public Course? GetById(int id)
    {
        foreach (var course in _courses)
        {
            if (course.Id == id) return course;
        }

        return null;
    }

    public IReadOnlyList<Course> GetAll() => _courses;


    public void Remove(int id)
    {
        var course = GetById(id);
        if (course == null) throw new ArgumentNullException("Id not fount");
        _courses.Remove(course);
    }
}