using EmployeeLibrary;
using System;

namespace PayRollClient
{
    class Program
    {
        static Employee CreateEmployee()
        {
            //1. Accepting values from user
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Basic Pay: ");
            decimal basicPay = decimal.Parse(Console.ReadLine());

            Console.Write("Da Pay: ");
            decimal daPay = decimal.Parse(Console.ReadLine());

            Console.Write("Hra Pay: ");
            decimal hraPay = decimal.Parse(Console.ReadLine());

            //2. creating an instance of employee class by invoking parameterized constructor and passing the values to it
            Employee employeeReference = new Employee(id, name, basicPay, daPay, hraPay);

            //3. returning the reference to the Main method
            return employeeReference;
        }
        static void Main()
        {
            //calling CreateEmployee method to create an instance of an employee class
            Employee employee = CreateEmployee();

            //calling CalculateSalary method to calculate salary
            decimal totalSalary = employee.CalculateSalary();

            //printing total salary
            Console.WriteLine($"Total Salary: {totalSalary}");
        }
    }
}
