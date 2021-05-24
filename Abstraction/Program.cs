using System;

namespace Abstraction
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public double GrossPay; //25000 //house rent -- 5000, convince allowance - 4000.
        public double TaxDeduction = 0.1; //10%
        public double NetSalary;

        public Employee(int eId,string eName,double eGrossPay)
        {
            this.EmpId = eId;
            this.EmpName = eName;
            this.GrossPay = eGrossPay;
        }

        void CalculateSalary()
        {
            Console.WriteLine("Your EmpId is: {0}", EmpId);
            Console.WriteLine("Your EmpName is: {0}", EmpName);
            if (GrossPay>=30000)
            {
                NetSalary = GrossPay - (TaxDeduction * GrossPay);
                Console.WriteLine("Your Salary is:{0}",NetSalary);
            }
            else
            {
                Console.WriteLine("Your Salary is: {0}", GrossPay);
            }
        }

        public void SalaryDetails()
        {
            this.CalculateSalary();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee=new Employee(100,"Rakib",25000);
            employee.SalaryDetails();

        }
    }
}
