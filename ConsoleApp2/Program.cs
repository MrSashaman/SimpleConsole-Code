using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the program!");


            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            GreetUser(userName);


            BirthDayUser();


            PerformMathOperation();
        }

        static void GreetUser(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("You didn't enter your name!");
            }
            else
            {
                Console.WriteLine($"Hello, {name}!");
            }
        }

        static void BirthDayUser()
        {
            // Запрашиваем дату рождения
            Console.Write("Please enter your birthday date (MM/DD/YYYY): ");
            string birthday = Console.ReadLine();

            // Отправляем дату в другую функцию для обработки
            BirthDayUserSend(birthday);
        }

        static void BirthDayUserSend(string birthday)
        {
            if (string.IsNullOrWhiteSpace(birthday))
            {
                Console.WriteLine("You didn't enter your birth date!");
            }
            else
            {
                Console.WriteLine($"Oh, your birthday is {birthday}!");
            }
        }

        static void PerformMathOperation()
        {
            try
            {
                Console.WriteLine("Let's perform a simple math operation.");
                Console.Write("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());

                int sum = num1 + num2;
                Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
            }
            catch (FormatException)
            {
                Console.WriteLine("You entered an invalid number. Please enter valid integers.");
            }
        }
    }
}
