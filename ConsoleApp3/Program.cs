using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static int ReadInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static string AddS ( double n)
        {
            if (n > 1)
                return "s";
            else return "";
        }
        static void Result (double n, string world)
        {
            if (n != 0)
                Console.Write(n + " "+  world + AddS(n) + " ");

        }
        static void Main(string[] args)
        {
            //lab 01

            int season = ReadInt("Количество сезонов   ");
            int serias = ReadInt("Количество серий в сезоне  ");
            int min = ReadInt("Средняя продолжительность серии в минутах   ");

            Console.WriteLine();
            int fullTime = season * serias * min;
            double min2 = fullTime % 60;
            double hours = (fullTime - min2 ) / 60;
            double days = Math.Truncate(hours / 24);
            hours -= days * 24;
            double months = Math.Truncate(days / 30);
            days -= months * 30;

            Console.WriteLine("Всего времени ушло: ");

            Result(months, "month");
            Result(days, "day");
            Result(hours, "hour");
            Result(min2, "min");

            Console.WriteLine();
        }
    }
}
