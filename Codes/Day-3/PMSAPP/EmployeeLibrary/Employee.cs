namespace EmployeeLibrary
{
    /// <summary>
    /// class representing an employee
    /// </summary>
    public class Employee
    {
        #region Data Members
        private int employeeId;
        private string employeeName;
        private string projectName;
        private decimal basicPayment;
        private decimal daPayment;
        private decimal hraPayment;
        #endregion

        #region Constructors
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
        /// <param name="project">project of employee</param>
        public Employee(int id, string name, decimal basicPay, decimal daPay, decimal hraPay, string project)
        {
            employeeId = id;
            employeeName = name;
            basicPayment = basicPay;
            daPayment = daPay;
            hraPayment = hraPay;
            projectName = project;
        }
        #endregion

        #region Properties
        //property function
        /// <summary>
        /// gets or sets the name
        /// </summary>
        public string EmployeeName
        {
            //public string GetName()
            get
            {
                return employeeName;
            }
            //public void SetName(string value)
            set
            {
                employeeName = value;
            }
        }
        /// <summary>
        /// gets or sets the id
        /// </summary>
        public int EmployeeId
        {
            set { employeeId = value; }
            get { return employeeId; }
        }
        /// <summary>
        /// gets or sets the project name
        /// </summary>
        public string ProjectName
        {
            set => projectName = value;
            get => projectName;
        }
        /// <summary>
        /// gets or sets the basic payment
        /// </summary>
        public decimal BasicPayment
        {
            get => basicPayment;
            set => basicPayment = value;
        }
        /// <summary>
        /// gets or sets the da payment
        /// </summary>
        public decimal DaPayment
        {
            get => daPayment;
            set => daPayment = value;
        }
        /// <summary>
        /// gets or sets the hra payment
        /// </summary>
        public decimal HraPayment
        {
            set { hraPayment = value; }
            get { return hraPayment; }
        }
        #endregion

        #region Methods
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
        #endregion
    }
}
