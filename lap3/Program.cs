using System;
using System.Linq;

namespace lap3
{
    enum Position { Manager, Leader, Senior, Junior }
    enum Jop_type { Full_Time, Part_Time }
    class Employee
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public float Salary { set; get; }
        public Position Position { set; get; }
        public Jop_type Jop_type { set; get; }

        public Employee() : this(-1, "", 0, Position.Manager, Jop_type.Full_Time) { }
        public Employee(int id, string name, float salary, Position position, Jop_type jop_type)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Position = position;
            Jop_type = jop_type;
        }

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
            Console.WriteLine($"*****************************************");
            Console.WriteLine($"Id = {Id}");
            Console.WriteLine($"Name is {Name}");
            Console.WriteLine($"Salary = {Salary}");
            Console.WriteLine($"Position is {Position}");
            Console.WriteLine($"Jop type is {Jop_type}");
            Console.WriteLine($"*****************************************");
        }

    }
    internal class Program
    {
        public static string reverse(string s)
        {
            //char [] chars = s.ToCharArray();
            //Array.Reverse(chars);
            //return new string(chars);
            string s_after_reverse = "";
            for(int i=s.Length - 1; i >= 0; i--)
            {
                s_after_reverse += s[i];
            }
            return s_after_reverse;
        }
        public static Boolean check_loggin(string username, string password)
        {
            string correct_username = "waleed_sayed", correct_password = "1234";
            return (username == correct_username && password == correct_password);
        }
        public static float calc_sum(int num_of_student, params float[] a)
        {
            float sum = 0;
            foreach(float f in a)
            {
                sum += f;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            ////////////////
            //   task 1   //
            ////////////////

            //Employee employee = new Employee();
            //Console.Write("Enter employee ID : ");
            //employee.Id=int.Parse(Console.ReadLine());
            //Console.Write("Enter employee Name : ");
            //employee.Name = Console.ReadLine();
            //Console.Write("Enter employee Salary : ");
            //employee.Salary = float.Parse(Console.ReadLine());
            //string p;
            //do
            //{
            //    Console.Write("Enter employee Position : ");
            //    p = Console.ReadLine();
            //    switch (p)
            //    {
            //        case "Manager":
            //            employee.Position = Position.Manager;
            //            break;
            //        case "Leader":
            //            employee.Position = Position.Leader;
            //            break;
            //        case "Senior":
            //            employee.Position = Position.Senior;
            //            break;
            //        case "Junior":
            //            employee.Position = Position.Junior;
            //            break;
            //        default:
            //            Console.WriteLine("error input!");
            //            break;
            //    }
            //} while (p != "Manager" && p != "Leader" && p != "Senior" && p != "Junior");

            //string j;
            //do
            //{
            //    Console.Write("Enter employee Jop Type : ");
            //    j = Console.ReadLine();
            //    switch (j)
            //    {
            //        case "Full_Time":
            //            employee.Jop_type = Jop_type.Full_Time;
            //            break;
            //        case "Part_Time":
            //            employee.Jop_type = Jop_type.Part_Time;
            //            break;
            //        default:
            //            Console.WriteLine("error input!");
            //            break;
            //    }
            //} while (j != "Full_Time" && j != "Part_Time");

            //employee.print_emp();

            ////////////////
            //   task 2   //
            ////////////////

            //Console.Write("Enter word to reverse it : ");
            //string word = Console.ReadLine();
            //Console.Write($"{word} after reverce {reverse(word)}");

            ////////////////
            //   task 3   //
            ////////////////

            //Console.Write("Enter your username : ");
            //string username = Console.ReadLine();
            //Console.Write("Enter your password : ");
            //string password = Console.ReadLine();
            //if(check_loggin(username, password))
            //{
            //    Console.WriteLine("Logged in");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect username or password try again!");
            //}

            ////////////////
            //   task 4   //
            ////////////////

            float[] a, res = new float[4];
            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Enter number of subjects that student {i} have : ");
                int num_of_subjects = int.Parse(Console.ReadLine());
                a = new float[num_of_subjects];
                for (int j = 0; j < num_of_subjects; j++)
                {
                    Console.Write($"Enter graids that student {i + 1} takes in subject number {j + 1} : ");
                    a[j] = float.Parse(Console.ReadLine());
                }
                res[i - 1] = calc_sum(i, a);
            }
            for(int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"Student number {i + 1} graids = {res[i]}");
            }
        }
    }
}
