using System;

namespace lab4task2
{
    public delegate void ValueHandler(string msg);
    public class Sender
    {
        public int I;
        public event ValueHandler Low;
        public event ValueHandler High;
        public void ReadData()
        {
            I = int.Parse(Console.ReadLine());
            if (I < 1)
            {
                if (Low != null)
                {
                    Low("out of Range,Number is too small");
                }
                else
                {
                    if (I > 100)
                    {
                        if (High != null)
                        {
                            High("Out of Range,Number is too large");
                        }
                    }
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Sender s = new Sender();

                s.Low += new ValueHandler(OnLow);
                s.High += new ValueHandler(OnHigh);
                s.ReadData();
            }
            static void OnLow(string str)
            {
                Console.WriteLine(str);
            }
            static void OnHigh(string str)
            {
                Console.WriteLine(str);
            }
        }
    }
}
