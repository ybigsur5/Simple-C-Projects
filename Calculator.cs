using System;

namespace ColorfulCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔═════════════════════════════════╗");
                Console.WriteLine("║         Calculator      ║");
                Console.WriteLine("╚═════════════════════════════════╝");
                Console.ResetColor();

                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter an operator (+, -, *, /): ");
                char op = Convert.ToChar(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0.0;

                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: Division by zero");
                            Console.ResetColor();
                            break;
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid operator");
                        Console.ResetColor();
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Result: {result}");
                Console.ResetColor();

                Console.Write("Do you want to perform another calculation? (Y/N): ");
                string continueCalculation = Console.ReadLine();
                if (continueCalculation.ToUpper() != "Y")
                    break;
            }
        }
    }
}