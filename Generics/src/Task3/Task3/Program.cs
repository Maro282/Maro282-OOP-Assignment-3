


using Task3;

var studentStore = new Store<Student>();
studentStore.Add(new Student(1, "Marwan"));
studentStore.Add(new Student(2, "Hazem"));
studentStore.Add(new Student(3, "Rady"));
studentStore.Add(new Student(4, "Mustafa"));
studentStore.Add(new Student(5, "Adham"));

var courseStore = new Store<Course>();
courseStore.Add(new Course(1, "C#", 1500m));
courseStore.Add(new Course(2, "C++", 3000m));
courseStore.Add(new Course(3, "Python", 2000m));

//Put 5 students in a Store<Student> and 3 courses in a Store<Course>; get one of each by id.
Console.WriteLine(courseStore.GetById(1)?.Title);
Console.WriteLine(studentStore.GetById(2)?.Name);

//Add a student with an id that already exists — catch the exception and print its message.
try
{
    studentStore.Add(new Student(1, "Hesham"));
}
catch (Exception e)
{
    Console.WriteLine($"Error =>  {e.Message}");
}

// Print page 2 (size 2) of the students, and call FindById on a plain List<Course>.

foreach (var student in studentStore.GetAll().Values.Page(2, 2))
{
    Console.WriteLine(student.Name);
}


//var stringStore = new Store<string>();
