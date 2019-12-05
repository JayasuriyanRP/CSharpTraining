namespace EmployeeLibrary
{
    /// <summary>
    /// class representing an employee
    /// </summary>
    public class Employee
    {
        private int employeeId;
        private string employeeName;
        private decimal basicPayment;
        private decimal daPayment;
        private decimal hraPayment;

        /// <summary>
        /// default constructor
        /// </summary>
        public Employee()
        {

        }
        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="id">id of employee</param>
        /// <param name="name">name of employee</param>
        /// <param name="basicPay">basic payment of employee</param>
        /// <param name="daPay">da payment of employee</param>
        /// <param name="hraPay">hra payment of employee</param>
        public Employee(int id, string name, decimal basicPay, decimal daPay, decimal hraPay)
        {
            employeeId = id;
            employeeName = name;
            basicPayment = basicPay;
            daPayment = daPay;
            hraPayment = hraPay;
        }
        /// <summary>
        /// method to calculate total salary of an employee
        /// </summary>
        /// <returns>
        /// returns calculated total salary of an employee
        /// </returns>
        public decimal CalculateSalary()
        {
            decimal totalSalary = basicPayment + daPayment + hraPayment;
            return totalSalary;
        }
    }
}
