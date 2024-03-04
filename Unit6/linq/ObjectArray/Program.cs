var students = new[]
{
    new StudentInfo { ID = 2, FirstName = "Jane", LastName = "Doe", GradeLevel = 3 },
    new StudentInfo { ID = 1, FirstName = "John", LastName = "Doe", GradeLevel = 1 },
    new StudentInfo { ID = 50001, FirstName = "Iramir", LastName = "Neto", GradeLevel = 6 }
};

// LINQ query to order students by grade level
var orderedStudents = students.Where(s => s.ID >= 50000).OrderBy(s => s.ID);

foreach (var student in orderedStudents)
    Console.WriteLine($"{student.FirstName} is in grade {student.GradeLevel}");


public class StudentInfo : IComparable<StudentInfo>
{
    public int ID { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public int GradeLevel { get; set; }

    // Implement the CompareTo method
    public int CompareTo(StudentInfo other)
    {
        // sorts students by their grade level 
        return this.GradeLevel.CompareTo(other.GradeLevel);
    }
}