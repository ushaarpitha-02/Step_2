using System;
namespace School
{


    class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public void ShowBasicDetails()
        {
            Console.WriteLine($"Name:{name},Age:{age},Gender:{gender}");
        }



    }
    class Student : Person
    {
        public string Grade { get; set; }
        public int RollNumber { get; set; }
        public Student(string name, int age, string gender, string grade, int rollNumber) : base(name, age, gender)
        {
            this.Grade = grade;
            this.RollNumber = rollNumber;
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine("*****Student Details******");
            ShowBasicDetails();
            Console.WriteLine($"Grade:{Grade}, RollNumber:{RollNumber}");
        }

    }
    class Teacher : Person
    {
        public string subjectname { get; set; }
        public int subjectID { get; set; }
        public Teacher(string name, int age, string gender, string subjectname, int subjectID) : base(name, age, gender)
        {
            this.subjectname = subjectname;
            this.subjectID = subjectID;

        }
        public void ShowTeacherDetails()
        {
            Console.WriteLine("*******Teacher Details********");
            ShowBasicDetails();
            Console.WriteLine($"Subject Name:{subjectname},SubjectID:{subjectID}");
        }
    }
        class Program
        {
            static void Main()
            {
                Student student = new Student("Usha", 25, "Female", "A+", 101);
                student.DisplayStudentDetails();
                Teacher teacher = new Teacher("Arpitha", 45, "Female", "Telugu", 901);
                teacher.ShowTeacherDetails();



            }
        }
    
}