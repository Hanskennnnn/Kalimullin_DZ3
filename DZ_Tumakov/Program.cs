using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task4_1();
        }

        //Задание 4.1, 4.2, 4.3.
        static void Task4_1()
        {
            int dayOfYear;
            int year;

     
            Console.Write("Введите номер дня в году (от 1 до 365): ");
            while (!int.TryParse(Console.ReadLine(), out dayOfYear) || dayOfYear < 1 || dayOfYear > 365)
            {
                Console.WriteLine("Ошибка: Введите корректное число от 1 до 365.");
                Console.Write("Введите номер дня в году (от 1 до 365): ");
            }

           
            Console.Write("Введите год: ");
            while (!int.TryParse(Console.ReadLine(), out year) || year <= 0)
            {
                Console.WriteLine("Ошибка: Введите корректный год (положительное целое число).");
                Console.Write("Введите год: ");
            }
            
            bool isLeapYear = IsLeapYear(year);

            
            string date = ConvertDayToDate(dayOfYear, isLeapYear);
            Console.WriteLine($"День {dayOfYear} соответствует дате: {date}");
        }

        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        static string ConvertDayToDate(int dayOfYear, bool isLeapYear)
        {
            int[] daysInMonth = isLeapYear
                ? new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }
                : new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] monthNames = { "января", "февраля", "марта", "апреля", "мая", "июня",
                                "июля", "августа", "сентября", "октября", "ноября", "декабря" };
            int month = 0;
            while (dayOfYear > daysInMonth[month])
            {
                dayOfYear -= daysInMonth[month];
                month++;
            }
            return $"{dayOfYear} {monthNames[month]}";
        }
    }

}


