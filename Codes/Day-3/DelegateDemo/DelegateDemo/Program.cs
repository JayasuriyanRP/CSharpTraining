using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    delegate void CalDel(int x, int y);
    class Calculation
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CalDel cdAdd = new CalDel(Calculation.Add);

            Calculation calc = new Calculation();
            CalDel cdSubtract = new CalDel(calc.Subtract);

            cdAdd.Invoke(12, 4);
            cdSubtract(12, 4);
        }
    }
}
