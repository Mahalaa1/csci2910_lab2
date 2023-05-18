using ConsoleTables;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Transactions;
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
            //AddNum();

            // Part 2: Take a user’s input number and input its multiplication table. The user can choose how high to multiply by.
            //MultiplicationTable();

            // Output the number of bytes in memory that each of the following number types uses and the minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.
            NumberTypes();
        }

        /// <summary>
        /// Print the output of adding two numbers from user input.
        /// </summary>
        public static void AddNum()
        {
            try
            {
                Console.WriteLine("Let's add two numbers together.\n");

                Console.Write("Enter a number to add: ");
                double firstNumber = double.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Choose a second number to add: ");
                double secondNumber = double.Parse(Console.ReadLine());
                Console.WriteLine();
            

                double sum = firstNumber + secondNumber;

                Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}\n");
            }
            catch (FormatException e)
            {
                Console.WriteLine("You must enter a number!");
            }

            Console.WriteLine("Thanks for using the program!");
        }

        /// <summary>
        /// Take a user’s input number and input its multiplication table. The user can choose how high to multiply by.
        /// </summary>
        public static void MultiplicationTable()
        {
            try
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
            catch (FormatException e)
            {
                Console.WriteLine("Enter a number you would like to see a multiplication table for and what number you want to mulitply to.");
            }

            Console.WriteLine("Thanks for using the program!");
        }

        /// <summary>
        /// Output the number of bytes in memory that each of the following number types uses and the minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.
        /// </summary>
        public static void NumberTypes()
        {
            var table = new ConsoleTable("Type", "Byte(s) of Memory", "Min", "Max");
            table.AddRow("sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            
            table.AddRow("byte", sizeof(byte), byte.MinValue, byte.MaxValue);
            
            table.AddRow("short", sizeof(short), short.MinValue, short.MaxValue);
           
            table.AddRow("ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            
            table.AddRow("int", sizeof(int), int.MinValue, int.MaxValue);
            
            table.AddRow("uint", sizeof(uint), uint.MinValue, uint.MaxValue);

            table.AddRow("long", sizeof(long), long.MinValue, long.MaxValue);

            table.AddRow("ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);

            table.AddRow("float", sizeof(float), float.MinValue, float.MaxValue);

            table.AddRow("double", sizeof(double), double.MinValue, double.MaxValue);

            table.AddRow("decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
            table.Write(Format.Minimal);

            Console.WriteLine("Thanks for using the program!");
        }
    }
}