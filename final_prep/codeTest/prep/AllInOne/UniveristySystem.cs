using System.ComponentModel;

namespace FinalPrep
{
    public abstract class Human //as the namespace already has a person :))
    {
        public string? Name;
        public int Age;

        public Human(string? name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

    }

    public class Student : Human
    {
        public int StudentID;
        public string? Major;

        public Student(string? name, int age, int studetnId, string? major)
            : base(name, age)
        {
            this.StudentID = studetnId;
            this.Major = major;
        }

        public override string ToString()
        {
            return base.ToString() + "Name: " + Name.ToString() + "Age: " + Age.ToString()
                + "Student ID: " + StudentID.ToString() + "Major: " + Major.ToString();
        }

        public void EnrollInCourse(string major)
        {
            if (major is not null)
                Console.WriteLine($"The student attends {major} classes");
            else
                Console.WriteLine($"The student is not attending {major} classes");
        }
    }

    public class Professor : Human
    {
        public int EmployeeID;
        public string? Department;

        public Professor(string? name, int age, string? department, int employeeID)
            : base(name, age)
        {
            this.Department = department;
            this.EmployeeID = employeeID;
        }

        public override string ToString()
        {
            return base.ToString() + "Name: " + Name.ToString() + "Age: " + Age.ToString()
                + "Employee ID: " + EmployeeID.ToString() + "Department: " + Department.ToString(); ;
        }

        public void TeachCourse(string major)
        {
            if (major is not null)
                Console.WriteLine($"The student teaches {major} classes");
            else
                Console.WriteLine($"The student is not teaching {major} classes");
        }
    }
}