using System;

namespace School
{
    public class Student1
    {
        public int Id;
        public string Name;

        public Student1(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine("Student ID: " + Id);
            Console.WriteLine("Student Name: " + Name);
        }
    }
}

namespace College
{
    public class Course
    {
        public string CourseName;
        public int Duration;

        public Course(string courseName, int duration)
        {
            CourseName = courseName;
            Duration = duration;
        }

        public void Show()
        {
            Console.WriteLine("Course Name: " + CourseName);
            Console.WriteLine("Duration: " + Duration + " months");
        }
    }
}

// Main program class — outside other namespaces
class Program1
{
    static void Main()
    {
        // Creating object of School.Student using full namespace
        School.Student1 student= new School.Student1(1, "Usha");
        student.Display();

        Console.WriteLine(); // blank line

        // Creating object of College.Course using full namespace
        College.Course course = new College.Course("Computer Science", 12);
        course.Show();
    }
}
