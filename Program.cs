using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. Если число кратно 3 (делится на 3 безостатка) нужно вывести слово Fizz. Если число кратно 5нужно вывести слово Buzz. Если число кратно 3 и 5 нужновывести Fizz Buzz. Если число не кратно не 3 и 5 нужновывести само число.Если пользователь ввел значение не в диапазоне от 1до 100 требуется вывести сообщение об ошибке.
            Console.WriteLine("Input choice 1 - 100:");
            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 100)
            {
                Console.WriteLine("Eror! Input choice 1 - 100");
            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
            #endregion
            #region Пользователь вводит с клавиатуры два числа. Первоечисло — это значение, второе число процент, которыйнеобходимо посчитать. Например, мы ввели с клавиатуры90 и 10. Требуется вывести на экран 10 процентов от 90.Результат: 9.
            Console.WriteLine("Enter two numbers space:");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            if (parts.Length != 2 || !int.TryParse(parts[0], out int value) || !int.TryParse(parts[1], out int percent))
            {
                Console.WriteLine("Error! Input 3 choice through a space");
            }
            else
            {
                double result = value * percent / 100.0;
                Console.WriteLine($"{percent}% from {value} = {result}");
            }
            #endregion
            #region Пользователь вводит с клавиатуры четыре цифры.Необходимо создать число, содержащее эти цифры.Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно сформировать число 1578.
            Console.WriteLine("Please enter four digits (no spaces)):");
            string input1 = Console.ReadLine();

            if (input.Length != 4 || !int.TryParse(input, out int val))
            {
                Console.WriteLine("Error! Enter four digits.");
            }
            else
            {
                Console.WriteLine($"A number made up of digits {input1}: {val}");
            }
            #endregion
            #region Пользователь вводит шестизначное число. После чегопользователь вводит номера разрядов для обмена цифр.Например, если пользователь ввёл один и шесть — этозначит, что надо обменять местами первую и шестуюцифры.
            Console.WriteLine("Enter a six-digit number:");
            string input2 = Console.ReadLine();

            if (input2.Length != 6 || !int.TryParse(input2, out int num))
            {
                Console.WriteLine("Error! Enter a six-digit number");
            }
            else
            {
                Console.WriteLine("Enter the numbers of digits for the exchange space:");
                string positionsInput = Console.ReadLine();
                string[] positions = positionsInput.Split(' ');

                if (positions.Length != 2 || !int.TryParse(positions[0], out int position1) || !int.TryParse(positions[1], out int position2) ||
                    position1 < 1 || position1 > 6 || position2 < 1 || position2 > 6)
                {
                    Console.WriteLine("Error! Enter two numbers of digits from 1 to 6 separated by a space");
                }
                else
                {
                    char[] digits = input.ToCharArray();
                    char temp = digits[position1 - 1];
                    digits[position1 - 1] = digits[position2 - 1];
                    digits[position2 - 1] = temp;
                    string result = new string(digits);
                    Console.WriteLine($"Result: {result}");
                }
            }
            #endregion
            #region Пользователь вводит с клавиатуры дату. Приложение должно отобразить название сезона и дня недели.Например, если введено 22.12.2021, приложение должноотобразить Winter Wednesday
            Console.Write("Enter a date in the format dd.mm.yyyy: ");
            string input3 = Console.ReadLine();

            if (DateTime.TryParseExact(input3, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                string season = "";
                switch (date.Month)
                {
                    case 12:
                    case 1:
                    case 2:
                        season = "Winter";
                        break;
                    case 3:
                    case 4:
                    case 5:
                        season = "Spring";
                        break;
                    case 6:
                    case 7:
                    case 8:
                        season = "Summer";
                        break;
                    case 9:
                    case 10:
                    case 11:
                        season = "Autumn";
                        break;
                }

                string dayOfWeek = date.DayOfWeek.ToString();

                Console.WriteLine($"{season} {dayOfWeek}");
            }
            else
            {
                Console.WriteLine("Date entry error!");
            }
            #endregion

            #region Пользователь вводит с клавиатуры показания температуры. В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсийили наоборот.
            Console.WriteLine("Enter temperature:");
            double temperature = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Convert from Fahrenheit to Celsius");
            Console.WriteLine("2. Convert from Celsius to Fahrenheit");

            int choice = int.Parse(Console.ReadLine());

            double result = 0;

            if (choice == 1)
            {
                result = (temperature - 32) * 5 / 9;
                Console.WriteLine("Temperature in Celsius: " + result);
            }
            else if (choice == 2)
            {
                result = temperature * 9 / 5 + 32;
                Console.WriteLine("Temperature in Fahrenheit: " + result);
            }
            else
            {
                Console.WriteLine("Eror");
                #endregion
            }
    }
}
