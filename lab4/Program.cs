using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        public delegate void MyDelegate();


        static int I;
        private static void Welcome()
        {
            Console.WriteLine("Welcome to Our Test Class");
        }
        private static void GoodBye()
        {
            Console.WriteLine("This is the end of our Class");
        }
        public static void PrintMessage(MyDelegate m)
        {
            Console.WriteLine("This Message from Test Class");
            m();
        }

        static void Main(string[] args)
        {
            I = int.Parse(Console.ReadLine());
            if (I < 5)
            {
                MyDelegate Message = new MyDelegate(Program.Welcome);
                PrintMessage(Message);
            }
            else
            {
                MyDelegate Message = new MyDelegate(Program.GoodBye);
                PrintMessage(Message);
            }
        }
    }
}
