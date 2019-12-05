using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("second app");
            int a = 10;
            long l = a;

            long l1 = 1234567890123;
            //int a1 = (int)l1;-->casting
            int a1 = checked((int)l1);
            //int a1 = Convert.ToInt32(l1);//<--Convert
            Console.WriteLine(a1);

            //Console.Write("Enter 1st Number: "); //12-->"12"-->12
            //string first = Console.ReadLine();
            //int firstValue = Convert.ToInt32(first);

            //Console.Write("Enter 2nd Number: ");
            //string second = Console.ReadLine();
            //Int32 secondValue = int.Parse(second);

            int firstValue = GetValue();
            int secondValue = GetValue();

            int addResult = Add(firstValue, secondValue);
            Console.WriteLine("Addition of {0} and {1} is {2}", firstValue, secondValue, addResult);

            Console.WriteLine(
                "Addition of "
                + firstValue
                + " and "
                + secondValue
                + " is "
                + addResult);

            //string interpolation or string template
            Console.WriteLine($"Addition of {firstValue} and {secondValue} is {addResult}");
        }
        private static int GetValue()
        {
            Console.Write("Enter a value: ");
            string stringValue = Console.ReadLine();
            int number = Convert.ToInt32(stringValue);
            return number;
        }
        private static int Add(int firstValue, int secondValue)
        {
            return (firstValue + secondValue);
        }
    }
}
