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

            Console.Write("Project Name: ");
            string projName = Console.ReadLine();

            Console.Write("Basic Pay: ");
            decimal basicPay = decimal.Parse(Console.ReadLine());

            Console.Write("Da Pay: ");
            decimal daPay = decimal.Parse(Console.ReadLine());

            Console.Write("Hra Pay: ");
            decimal hraPay = decimal.Parse(Console.ReadLine());

            //2. creating an instance of employee class by invoking parameterized constructor and passing the values to it
            Employee employeeReference = new Employee(id, name, basicPay, daPay, hraPay, projName);

            //3. returning the reference to the Main method
            return employeeReference;
        }

        static int GetRecordCount()
        {
            Console.Write("how many records?");
            int records = int.Parse(Console.ReadLine());
            return records;
        }

        static void StoreEmployee(Employee[] employees)
        {
            for (int index = 0; index < employees.Length; index++)
            {
                //calling CreateEmployee method to create an instance of an employee class
                Employee employee = CreateEmployee();
                employees[index] = employee;
            }
        }

        static void CalculateAndPrintSalary(Employee[] employees)
        {
            for (int index = 0; index < employees.Length; index++)
            {
                Employee employeeRef = employees[index];
                //calling CalculateSalary method to calculate salary
                decimal totalSalary = employeeRef.CalculateSalary();

                //printing total salary
                Console.WriteLine($"Total Salary of {employeeRef.EmployeeName} is {totalSalary}");
            }
        }
        static void Main()
        {
            //1. ask user about number of employee records
            int recordNumber = GetRecordCount();

            //2. creating an array to store the references of employee objects to be created
            Employee[] employees = new Employee[recordNumber];

            //3. storing references of employee objects
            StoreEmployee(employees);

            //resetting the project name
            //employee.ProjectName = "CITA";

            //4. calculate salary of every employee and print the same
            CalculateAndPrintSalary(employees);
        }
    }
}
