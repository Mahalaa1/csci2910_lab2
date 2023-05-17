namespace csci2910_lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Print the output of adding two numbers from user input.
            AddNum();
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

    }
}