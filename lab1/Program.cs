using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        //enum Week { Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday }
        //enum Week { Saturday = 10, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday }
        enum Week { Saturday = 5, Sunday = 11, Monday = 15, Tuesday = 25, Wednesday = 16, Thursday, Friday }
        static void Main(string[] args)
        {
            Console.Write("Enter day which you need to show it's index : ");
            string s=Console.ReadLine();
            Week day_in_a_week=Week.Sunday;
            bool flag = true;
            switch (s)
            {
                case "Saturday":
                    day_in_a_week = Week.Saturday;
                    break;
                case "Sunday":
                    day_in_a_week = Week.Sunday;
                    break;
                case "Monday":
                    day_in_a_week = Week.Monday;
                    break;
                case "Tuesday":
                    day_in_a_week = Week.Tuesday;
                    break;
                case "Wednesday":
                    day_in_a_week = Week.Wednesday;
                    break;
                case "Thursday":
                    day_in_a_week = Week.Thursday;
                    break;
                case "Friday":
                    day_in_a_week = Week.Friday;
                    break;
                default:
                    Console.WriteLine("Error input !");
                    flag = false;
                    break;
                
            }
            int index = (int)day_in_a_week;
            if (flag)
            {
                Console.WriteLine($"The index of {s} is {index}");
            }
            Console.Write("Enter index of day which you need to show : ");
            index = int.Parse(Console.ReadLine());
            int min = (int)Week.Saturday, max = (int)Week.Friday;
            if (index == (int)Week.Saturday || index == (int)Week.Sunday || index == (int)Week.Monday || index == (int)Week.Tuesday || index == (int)Week.Wednesday || index == (int)Week.Thursday || index == (int)Week.Friday)
            {
                day_in_a_week = (Week)index;
                Console.WriteLine($"The day in index {index} is {day_in_a_week}");
            }
            else
            {
                Console.WriteLine("Error input !");
            }

            Console.ReadKey();
        }
    }
}
