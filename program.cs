using System;

namespace BincomCSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // var declaration for the first very task ...task 1
            string name = "John Doe";
            int age = 25;
            bool isAdmin = true;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Is Admin: {isAdmin}");
            Console.WriteLine();

            // even and odd checker using the readline method ... task 2
            Console.Write("Enter an integer: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            Console.WriteLine();

            // for loop to print numbers from 1 --- 10 ... task 3
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // array of integers and calculate the sum of its elements ... task 4
            int[] numbers = { 2, 4, 6, 8, 10 };
            int sum = 0;

            Console.WriteLine("Array elements:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
                sum += num;
            }

            Console.WriteLine($"Sum of elements: {sum}");
            Console.WriteLine();

            // method to greet a user by name ... task 5
            Greet("Alice");
        }

        static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}