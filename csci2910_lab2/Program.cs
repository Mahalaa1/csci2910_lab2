/**
*--------------------------------------------------------------------
* File name: Program.cs
* Project name: Lab2
*--------------------------------------------------------------------
* Author’s name and email: Austin Mahala, mahalaa1@etsu.edu
* Course-Section: CSCI-2910-970
* Creation Date: 5/17/2023
* -------------------------------------------------------------------
*/

namespace csci2910_lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Print the output of adding two numbers from user input.
            AddNum();

            // Part 2: Take a user’s input number and input its multiplication table. The user can choose how high to multiply by.
            MultiplicationTable();
        }

        public static void AddNum()
        {
            Console.WriteLine("Let's add two numbers together.");
            Console.WriteLine();

            Console.Write("Enter a number to add: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Choose a second number to add: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double sum = firstNumber + secondNumber;

            Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");
            Console.WriteLine();
        }

        public static void MultiplicationTable()
        {
            Console.WriteLine("Now let's make a multiplication table.");
            Console.WriteLine();

            Console.Write("What number would you like to see the multiplication table for? ");
            int tableNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("How high would you like to multiply by? ");
            int tableLength = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i <= tableLength; i++)
            {
                int result = tableNumber * i;
                Console.WriteLine($"{tableNumber} * {i} = {result}");
            }

        }
}