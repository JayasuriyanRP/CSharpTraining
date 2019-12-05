using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Objects
{
    class Program
    {
        static EmployeeInfo GetValues()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            Console.Write("Department: ");
            string department = Console.ReadLine();

            //EmployeeInfo empReference = new EmployeeInfo();
            EmployeeInfo empReference = new EmployeeInfo(id, name, department, salary);
            //empReference.Assign(id, name, department, salary);
            return empReference;
        }
        static void Main()
        {
            //for (int i = 0; i < 20; i++)
            //{
            EmployeeInfo infoAddress = GetValues();
            string info = infoAddress.Print();
            Console.WriteLine(info);
            //}
        }
    }
}
