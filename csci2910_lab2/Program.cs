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
            string userChoice;
            do
            {
                Console.WriteLine("Welcome to this program!\n");
                Console.WriteLine("Select an option by entering the corresponding number.\n");

                Console.WriteLine("1: Add two numbers together.");
                Console.WriteLine("2: Create a multiplication table.");
                Console.WriteLine("3: See the number data types and their values in memory.");
                Console.WriteLine("4: Use a calculator to add, subtract, multiply, divide, or use the modulus function.");
                Console.WriteLine("0: to exit\n");
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        // Part 1: Print the output of adding two numbers from user input.
                        AddNum();
                        break;

                    case "2":
                        // Part 2: Take a user’s input number and input its multiplication table. The user can choose how high to   multiply by.
                        MultiplicationTable();
                        break;

                    case "3":
                        // Part 3: Output the number of bytes in memory that each of the following number types uses and the minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.
                        NumberTypes();
                        break;

                    case "4":
                        // Part 4: Create a 5 function (+, -, *, /, and modulus) calculator. This calculator should loop until ‘esc’ is typed. For example, I should be asked for num 1, then some operation (+, -, *, /, and modulus) to another num 2. Provide the results, and then provide a way to esc the program or do another operation (+, -, *, /, and modulus) to the result.
                        Calculator();
                        break;

                    case "0":
                        Console.WriteLine("Thank you for using the program!");
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Sorry, That input is invalid.");
                        break;
                }
            }
            while (userChoice != "0");
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
                Console.WriteLine("You must enter a number!\n");
            }

            Console.WriteLine("Thanks for using the add numbers portion!\n\n");
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
                Console.WriteLine("Enter a number you would like to see a multiplication table for and what number you want to mulitply to.\n");
            }

            Console.WriteLine("Thanks for using the multiplication table!\n\n");
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

            Console.WriteLine("\nThanks for viewing this table!\n");
        }

        /// <summary>
        /// Create a 5 function (+, -, *, /, and modulus) calculator. This calculator should loop until ‘esc’ is typed. For example, I should be asked for num 1, then some operation (+, -, *, /, and modulus) to another num 2. Provide the results, and then provide a way to esc the program or do another operation (+, -, *, /, and modulus) to the result.
        /// </summary>
        public static void Calculator()
        {
            bool escape = false;
            double numOne;
            double numTwo;
            string exit = "";
            do
            {
                try
                {
                    Console.Write("Enter a number: ");
                    numOne = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Console.Write("What kind of operation would you like to use? " +
                        "\nChoose between Add +, Subtract -, Multiply *, Divide /, or Modulus %: ");
                    string operation = Console.ReadLine();

                    switch (operation)
                    {
                        case "+":
                            Console.WriteLine();
                            Console.Write("Enter a number to add to the other number: ");
                            numTwo = double.Parse(Console.ReadLine());
                            double sum = numOne + numTwo;
                            Console.WriteLine();

                            Console.WriteLine($"{numOne} + {numTwo} = {sum}");
                            Console.WriteLine();
                            break;

                        case "-":
                            Console.WriteLine();
                            Console.Write("Enter a number to subtract from the other number: ");
                            numTwo = double.Parse(Console.ReadLine());
                            double difference = numOne - numTwo;
                            Console.WriteLine();

                            Console.WriteLine($"{numOne} - {numTwo} = {difference}");
                            Console.WriteLine();
                            break;

                        case "*":
                            Console.WriteLine();
                            Console.Write("Enter a number to multiply the other number by: ");
                            numTwo = double.Parse(Console.ReadLine());
                            double product = numOne * numTwo;
                            Console.WriteLine();

                            Console.WriteLine($"{numOne} * {numTwo} = {product}");
                            Console.WriteLine();
                            break;

                        case "/":
                            Console.WriteLine();
                            Console.Write("Enter a number to divide from the other number: ");
                            numTwo = double.Parse(Console.ReadLine());
                            double quotient = numOne / numTwo;
                            Console.WriteLine();

                            Console.WriteLine($"{numOne} / {numTwo} = {quotient}");
                            Console.WriteLine();
                            break;

                        case "%":
                            Console.WriteLine();
                            Console.Write("Enter a number to divide from the other number and show the remainder: ");
                            numTwo = double.Parse(Console.ReadLine());
                            double remainder = numOne % numTwo;
                            Console.WriteLine();

                            Console.WriteLine($"{numOne} % {numTwo} = {remainder}");
                            Console.WriteLine();
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("\nMake sure you enter a valid input! Enter a number where it says to enter a number and select the appropriate operator!\n");
                }

                try
                {
                    Console.Write("\nIf you would like to exit, type 'esc'. If you would like to continue using the calculator, press the enter key: ");
                    exit = Console.ReadLine();
                    if (exit == "esc")
                    {
                        escape = true;
                        Console.WriteLine("Thanks for using this calculator!\n\n");
                    }
                    Console.WriteLine();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\nTo exit, make sure you enter 'esc' or to continue, press enter!\n");
                    exit = Console.ReadLine();
                    if (exit == "esc")
                    {
                        escape = true;
                        Console.WriteLine("Thanks for using this calculator!\n\n");
                    }
                    Console.WriteLine();
                }
            }
            while (escape == false);
        }
    }
}