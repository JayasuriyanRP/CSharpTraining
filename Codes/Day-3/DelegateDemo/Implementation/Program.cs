using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    delegate int SomeDel(int a, int b);

    delegate bool LogicInvoker(int num);
    class Logic
    {
        public bool IsEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }
        public bool IsOdd(int number)
        {
            return number % 2 != 0 ? true : false;
        }
    }
    class Program
    {
        static List<int> Filter(List<int> inputList, LogicInvoker invoker)
        {
            List<int> filtered = new List<int>();
            foreach (var number in inputList)
            {
                bool success = invoker(number);
                if (success)
                {
                    filtered.Add(number);
                }
            }
            return filtered;
        }
        static void Main()
        {
            //source of data
            List<int> numbers = new List<int> { 1, 4, 2, 5, 6, 3, 0, 7, 9, 8 };

            //create delegate to refer a method
            //LogicInvoker logicDel = new LogicInvoker(new Logic().IsOdd);

            //LogicInvoker logicDel = delegate (int num)
            //  {
            //      return num > 3 ? true : false;
            //  };
            //Lambda expression: representing anonymous method
            LogicInvoker logicDel = num => num > 3;

            //pass source of data to be filtered and the logic through a delegate object to filter
            List<int> output = Filter(numbers, logicDel);

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            SomeDel sdAdd = delegate (int x, int y)
            {
                return (x + y);
            };
            SomeDel sdSubtract = (a, b) => (a - b);
        }
    }
}
