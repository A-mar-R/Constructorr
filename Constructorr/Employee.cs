using System;
namespace ConsoleApp
{

    class Teacher
    {
        string ClgName = "GFCCT";
        private Teacher()
        {
            Console.WriteLine("College Name is "+ClgName);
        }
        public static Teacher CreateObject()
        {
            return new Teacher();
        }
    }

    static class Student
    {
        public static int id;
        public static string name;
        public static int age;
       
        
        static Student()
        {
            id = 1;
            name = "Anand";
            age = 23;
        }
        public static void GetDetails()
        {
            Console.WriteLine("Student id is "+ id);
            Console.WriteLine("student Name is "+name);
            Console.WriteLine("Student Age is "+age);
        }
    }
    class Employee
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int Age;
        public Employee()
        {
            Console.WriteLine("Default Constructor invokes");
        }
        public Employee(int id, string firstName, string lastName, int age)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public Employee(Employee e)
        {
            Id = e.Id;
            FirstName = e.FirstName;
            LastName = e.LastName;
            Age = e.Age;
        }
        public void getEmployeeDetails()
        {
            Console.WriteLine("Employee Id is "+Id);
            Console.WriteLine("Employee First Name is "+FirstName);
            Console.WriteLine("Employee Last Name is "+LastName);
            Console.WriteLine("Employee Age is "+Age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Employee e1 = new Employee(1,"Amar","Jadhav",23);
            Employee e2 = new Employee(e1);
            e1.getEmployeeDetails();
            e2.getEmployeeDetails();

            Student.GetDetails();

            Teacher.CreateObject();
        }
    }
}