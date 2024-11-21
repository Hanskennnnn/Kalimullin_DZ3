using System;


namespace Kalimullin_DZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
        }

        //Задание 1
        static void Task1()
        {
            Console.WriteLine("Задание 1");
            int[] numbers = new int[10];

        
            Console.WriteLine("Введите последовательность из 10 чисел:");
            for (int i = 0; i < numbers.Length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Ошибка ввода. Введите целое число:");
                }               
            }
            for (int i=0; i < (numbers.Length)-1; i++)
            {
                if (!(numbers[i] < numbers[i + 1]))
                {
                    Console.WriteLine($"Порядковый номер числа на котором последовательность перестает возрастать: {i+2}");
                    break;
                    
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        //Задание 2
        static void Task2()
        {
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите номер карты (от 6 до 14):");
            try
            {
                int k = 0;
                while (!int.TryParse(Console.ReadLine(), out k) || k<6 || k>14)
                {
                    Console.WriteLine("Ошибка ввода.Введите правильный номер карты.");
                }
                
               
                if (k < 6 || k > 14)
                {
                    throw new ArgumentOutOfRangeException("Номер карты должен быть в диапазоне от 6 до 14.");
                }
                string cardName = GetCardName(k);
                Console.WriteLine($"Карта с номером {k} — это {cardName}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите целое число.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Программа завершила выполнение.");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static string GetCardName(int k)
        {
            string cardName;
            switch (k)
            {
                case 6:
                    cardName = "шестерка";
                    break;
                case 7:
                    cardName = "семерка";
                    break;
                case 8:
                    cardName = "восьмерка";
                    break;
                case 9:
                    cardName = "девятка";
                    break;
                case 10:
                    cardName = "десятка";
                    break;
                case 11:
                    cardName = "валет";
                    break;
                case 12:
                    cardName = "дама";
                    break;
                case 13:
                    cardName = "король";
                    break;
                case 14:
                    cardName = "туз";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return cardName;
        }




        //Задание 3
        static void Task3()
        {
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите входные данные:");
            string input = Console.ReadLine();
            string result = GetResponse(input.ToLower());

            Console.WriteLine(result);
            Console.WriteLine();
            Console.WriteLine();
        }

        static string GetResponse(string input)
        {

            switch (input)
            {
                case "jabroni":
                    return "Patron Tequila";
                case "school counselor":
                    return "Anything With Alcohol";
                case "programmer":
                    return "Hipster Craft Beer";
                case "bike gang member":
                    return "Moonshine";
                case "politician":
                    return "Your tax dollars";
                case "rapper":
                    return "Crystal";
                default:
                    return "Beer";
            }
        }
        static void Task4()
        {
            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите номер дня недели (1-7):");
            int dayNumber;
            while (!int.TryParse(Console.ReadLine(), out dayNumber) || dayNumber < 1 || dayNumber > 7)
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите число от 1 до 7.");
            }
            DayOfWeek day = (DayOfWeek)dayNumber;
            Console.WriteLine($"День недели: {day}");
            Console.WriteLine();
            Console.WriteLine();
        }


        public enum DayOfWeek
        {
           Понедельник = 1,
           Вторник=2,
           Среда=3,
           Четверг=4,
           Пятника=5,
           Суббота=6,
           Воскресенье=7
        }
        static void Task5()
        {
            string[] toys = { "Hello Kitty", "Barbie doll", "Toy car", "Beer" ,"Lego set", "Hello Kitty", "Barbie doll", "Puzzle","Vodka" };
            int dollCount = 0;
            Console.WriteLine("Массив игрушек:");
            foreach (var toy in toys)
            {
                Console.WriteLine(toy);
            }
            foreach (string toy in toys)
            {
                if (toy == "Hello Kitty" || toy == "Barbie doll")
                {
                    dollCount++;
                }
            }
            Console.WriteLine($"Количество кукол в сумке: {dollCount}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }


}

