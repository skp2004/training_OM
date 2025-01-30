using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
    public int CourseId { get; set; } // Foreign key for Join
}

class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
}
namespace MyApp
{
    class Linq
    {
        public static void LINQ()
        {

            List<Student> students =
            [
                new Student { Id = 1, Name = "shashwat", Marks = 85, CourseId = 101 },
            new Student { Id = 2, Name = "yovan", Marks = 92, CourseId = 102 },
            new Student { Id = 3, Name = "sahil", Marks = 78, CourseId = 101 },
            new Student { Id = 4, Name = "kirtan", Marks = 88, CourseId = 103 },
            new Student { Id = 5, Name = "jay", Marks = 65, CourseId = 102 }
            ];

            List<Course> courses =
            [
                new Course { CourseId = 101, CourseName = "Mathematics" },
            new Course { CourseId = 102, CourseName = "Science" },
            new Course { CourseId = 103, CourseName = "History" }
            ];

            // 1. Filter
            var highScorers = students.Where(s => s.Marks > 80);
            Console.WriteLine("Students with Marks > 80:");
            foreach (var student in highScorers)
                Console.WriteLine(student.Name);

            // 2. Sort
            var sortedStudents = students.OrderByDescending(s => s.Marks);
            Console.WriteLine("\nStudents Sorted by Marks:");
            foreach (var student in sortedStudents)
                Console.WriteLine($"{student.Name}: {student.Marks}");

            // 3. Select
            var studentNames = students.Select(s => s.Name);
            Console.WriteLine("\nStudent Names: " + string.Join(", ", studentNames));

            // 4. Aggregation: Count, Sum, Average
            int studentCount = students.Count;
            int totalMarks = students.Sum(s => s.Marks);
            double averageMarks = students.Average(s => s.Marks);

            Console.WriteLine($"\nTotal Students: {studentCount}");
            Console.WriteLine($"Total Marks: {totalMarks}");
            Console.WriteLine($"Average Marks: {averageMarks:F2}");

            // 5. First and Last Elements
            var topStudent = students.OrderByDescending(s => s.Marks).First();
            var lastStudent = students.OrderBy(s => s.Marks).First();

            Console.WriteLine($"\nTop Student: {topStudent.Name} ({topStudent.Marks})");
            Console.WriteLine($"Lowest Scorer: {lastStudent.Name} ({lastStudent.Marks})");

    

            // 6. Join
            var studentCourses = students.Join(
                courses,
                student => student.CourseId,
                course => course.CourseId,
                (student, course) => new
                {
                    student.Name,
                    student.Marks,
                    course.CourseName
                });

            Console.WriteLine("\nStudents :");
            foreach (var entry in studentCourses)
            {
                Console.WriteLine($"{entry.Name} ({entry.Marks}) - {entry.CourseName}");
            }
        }
    }
}