using System;

namespace DateTimePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeNow();
        }

        static void TimeNow()
        {
            Console.WriteLine($"Today is{DateTime.Now.Day}  of {DateTime.Now.ToString("MMMM")} oof {DateTime.Now.Year}. it is {DateTime.Now.ToString("hh:mm:ss")}  ");
        }
    }
}
