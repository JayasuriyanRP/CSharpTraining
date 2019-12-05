using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Objects
{
    class EmployeeInfo
    {
        private int empId;
        private string empName;
        private string empDept;
        private decimal empSalary;
        //public const string company = "siemens";
        //public static string company = "siemens";
        static string company;

        static EmployeeInfo()
        {
            company = "siemens";
        }

        //default constructor
        public EmployeeInfo()
        {
            //empDept = null;
            //empName = null;
            //empId = 0;
            //empSalary = 0.0M;
        }
        public EmployeeInfo(int id, string name, string dept, decimal salary)
        {
            empId = id;
            empName = name;
            empDept = dept;
            empSalary = salary;
        }
        //public void Assign(int id, string name, string dept, decimal salary)
        //{
        //    empId = id;
        //    empName = name;
        //    empDept = dept;
        //    empSalary = salary;
        //    company = "";
        //}
        //public static void Test()
        //{

        //}
        public string Print()
        {
            return $"Name: {empName}, Id: {empId}, Salary:{empSalary} and department: {empDept} belongs to {company}";
        }
    }
}
