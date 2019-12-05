using System;
using CalculatorLibrary;

namespace FirstConsole
{
    class Program
    {
        static void PrintMenu()
        {
            Console.WriteLine("\t-----MENU------");
            Console.WriteLine("\t1. Add");
            Console.WriteLine("\t2. Subtract");
            Console.WriteLine("\t3. Multiply");
            Console.WriteLine("\t4. Divide");
        }
        static int GetChoice()
        {
            Console.Write("\nEnter Choice[1/2/3/4]: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        static int GetValue()
        {
            Console.Write("Enter a number: ");
            string stringValue = Console.ReadLine();
            int number = Convert.ToInt32(stringValue);
            return number;
        }
        static char ChangeDecision()
        {
            Console.Write("\nWould you like to continue[y/Y/n/N]: ");
            char temp = char.Parse(Console.ReadLine());
            if (char.IsUpper(temp))
                temp = char.ToLower(temp);

            return temp;
        }
        static void Main()
        {
            char toContinue = 'n';

            do
            {
                PrintMenu();
                int choice = GetChoice();

               // Console.WriteLine("\n");
                int firstValue = GetValue();
                int secondValue = GetValue();
                //Console.WriteLine("\n");

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Calling Add Method");
                        int addResult = Calculator.Add(firstValue, secondValue);
                        Console.WriteLine($"Addition of {firstValue} and {secondValue} is {addResult}");
                        break;

                    case 2:
                        Console.WriteLine("Calling Subtract Method");
                        int subtractResult = Calculator.Subtract(firstValue, secondValue);
                        Console.WriteLine($"Subtraction of {firstValue} and {secondValue} is {subtractResult}");
                        break;

                    case 3:
                        Console.WriteLine("Calling Multiply Method");
                        int multiplicationResult = Calculator.Multiply(firstValue, secondValue);
                        Console.WriteLine($"Multiplication of {firstValue} and {secondValue} is {multiplicationResult}");
                        break;

                    case 4:
                        Console.WriteLine("Calling Division Method");
                        int divisionResult = Calculator.Divide(firstValue, secondValue);
                        Console.WriteLine($"Division of {firstValue} and {secondValue} is {divisionResult}");
                        break;

                    default:
                        Console.WriteLine("Enter a proper choice.");
                        break;
                }

                toContinue = ChangeDecision();
                Console.WriteLine("\n");

            } while (toContinue != 'n');

            Console.WriteLine("\nPress any key to terminate the application..");
            Console.Read();
        }
    }
}
