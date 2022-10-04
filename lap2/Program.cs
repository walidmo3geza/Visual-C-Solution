using System;

namespace lap2
{
    enum Position { Manager, Leader, Senior, Junior }
    enum Jop_type { Full_Time, Part_Time }
    struct Employee
    {
        public int Id;
        public string Name;
        public float Salary;
        public Position Position;
        public Jop_type Jop_type;
        public void fill_emp(int id, string name, float salary, Position p, Jop_type j)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Position = p;
            Jop_type = j;
        }
        public void print_emp()
        {
            Console.WriteLine($"Id = {Id}");
            Console.WriteLine($"Name is {Name}");
            Console.WriteLine($"Salary = {Salary}");
            Console.WriteLine($"Position is {Position}");
            Console.WriteLine($"Jop type is {Jop_type}");
        }

    }
    class Student
    {
        int Id;
        string Name;
        float Total_graids;
        public Student()
        {
            Id = 0;
            Name = "";
            Total_graids = 0;
        }
        public Student(int id, string name, float total_graids)
        {
            Id = id;
            Name = name;
            Total_graids = total_graids;
        }
        public void setId(int id) { Id = id; }
        public void setName(string name) { Name = name; }
        public void setTotal_graids(float total_graids) { Total_graids = total_graids; }
        public float getTotal_graids() { return Total_graids; }
        public int getId() { return Id; }
        public string getName() { return Name; }
        public void print_student()
        {
            Console.WriteLine($"Id = {Id}");
            Console.WriteLine($"Name is {Name}");
            Console.WriteLine($"Total graids = {Total_graids}");
            Console.WriteLine("******************************************************");
        }
    }
    class Test
    {
        public void edit_student_info(Student student)
        {
            student.setId(10);
            student.setName("Ahmed");
            student.setTotal_graids(100f);
        }
    }
    internal class Program
    {
        public static void wellcome(params string[] a)
        {
            foreach(string s in a)
            {
                Console.WriteLine($"Wellcome to you Mr/s {s}");
            }
        }
        static void Main(string[] args)
        {
            ////////////////
            //   task 1   //
            ////////////////

            //**********************************
            Employee employee = new Employee();
            employee.fill_emp(1, "Ali", 5000.5f, Position.Manager, Jop_type.Full_Time);
            employee.print_emp();

            ////////////////
            //   task 2   //
            ////////////////

            //wellcome("Ali", "Hussin", "Mostafa", "Ahmed");


            ////////////////
            //   task 3   //
            ////////////////

            //Student student = new Student(1, "any", 125);
            //student.print_student();

            //Test test = new Test();
            //test.edit_student_info(student);

            //student.print_student();
        }
    }
}
