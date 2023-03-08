// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");
ClassRoom classRoom = new ClassRoom();
classRoom.AddStudent(new Student { Id = 4, Name = "Türkay" });
classRoom.AddStudent(new Student { Id = 2, Name = "Ceyda" });
classRoom.AddStudent(new Student { Id = 1, Name = "Nihal" });
classRoom.AddStudent(new Student { Id = 3, Name = "Esmanur" });

var sorted = classRoom.GetSortedStudents();
foreach (var item in classRoom)
{
    Console.WriteLine($"{item.Id} {item.Name}");
}





public class Student : IComparable<Student>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int CompareTo(Student? other)
    {
        if (Id < other.Id)
        {
            return -1;
        }
        else if (Id > other.Id)
        {
            return 1;
        }

        return 0;
    }
}

public class ClassRoom : IEnumerable<Student>
{
    private List<Student> students = new List<Student>();
    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public IEnumerator<Student> GetEnumerator()
    {
        foreach (var student in students)
        {
            yield return student;
        }
    }

    public List<Student> GetSortedStudents()
    {
        students.Sort();
        return students;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
