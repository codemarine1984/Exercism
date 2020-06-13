using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private class Student
    {
        public Student(int grade, string name)
        {
            Grade = grade;
            Name = name;
        }
        public int Grade { get; private set; }
        public string Name { get; private set; }
    }

    private ICollection<Student> _roster;

    public GradeSchool() => _roster = new List<Student>();

    public void Add(string student, int grade) => _roster.Add(new Student(grade, student));

    public IEnumerable<string> Roster() => _roster.OrderBy(x => x.Grade).ThenBy(x => x.Name)
        .Select(x => x.Name);

    public IEnumerable<string> Grade(int grade) => _roster.Where(x => x.Grade == grade)
        .OrderBy(x => x.Name).Select(x => x.Name);
}