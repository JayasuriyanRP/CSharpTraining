using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDimArray
{
    class Program
    {
        static void Main()
        {
            /*
            //Array arrayReference = new Array(typeof(int),3);
            int[] arrayReference = new int[3];

            for (int index = 0; index < arrayReference.Length; index++)
            {
                Console.WriteLine($"value at arrayReference[{index}]:{arrayReference[index]}");
            }

            arrayReference[0] = 10;
            arrayReference[1] = 20;
            arrayReference[2] = 30;
            Console.WriteLine("\n");
            foreach (int value in arrayReference)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
            string[] names = new string[3];
            for (int index = 0; index < names.Length; index++)
            {
                Console.Write($"enter nane at names[{index}]: ");
                string name = Console.ReadLine();
                names[index] = name;
            }
            Console.WriteLine();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            */
            int[,] twoDimArray = new int[3, 2];

            Console.WriteLine();
            for (int rowIndex = 0; rowIndex < twoDimArray.GetLength(0); rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < twoDimArray.GetLength(1); columnIndex++)
                {
                    Console.Write($"enter value at twoDimArray[{rowIndex},{columnIndex}]: ");
                    int value = int.Parse(Console.ReadLine());
                    twoDimArray[rowIndex, columnIndex] = value;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int rowIndex = 0; rowIndex < twoDimArray.GetLength(0); rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < twoDimArray.GetLength(1); columnIndex++)
                {
                    Console.WriteLine($"value at twoDimArray[{rowIndex},{columnIndex}]:{twoDimArray[rowIndex, columnIndex]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
