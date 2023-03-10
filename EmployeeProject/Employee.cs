using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    public class Employee
    {
        public int empId;  //non-static variable or instance variable 
        public string empName;
        private double _empSalary;
        public char empPerformanceType;
        public static string companyName; //static variable or class variable 
        public static string companyLocation;

        //create similar method for student type and item type 
        public static void PrintAllEmployees(Employee[] employees)
        {
            foreach (Employee emp in employees)
            {
                emp.PrintEmployeeDetail();
                //Console.WriteLine(emp.empId);
                //Console.WriteLine(emp.empName);
                //Console.WriteLine("--------------------------");
            }
        }

        public static Employee getHighPaidEmployeeDetail(Employee e1, Employee e2)
        {
            if (e1.EmployeeSalary > e2.EmployeeSalary)
            {
                return e1;
            }
            else
            {
                return e2;
            }
        }

        public double EmployeeSalary
        {
            get
            {
                //read
                return _empSalary;
            }

            set
            {
                //write
                if (value > 3000)
                {
                    _empSalary = value;
                }
                else
                {
                    Console.WriteLine("Invalid Salary. So default value remains!!!");
                }
            }
        }



        public void PrintEmployeeDetail()
        {
            Console.WriteLine("Employee Id: " + empId);
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Employee Salary: " + _empSalary);
            Console.WriteLine("Employee Performance type: " + empPerformanceType);
            Console.WriteLine("Company Name: " + Employee.companyName);
            Console.WriteLine("Company Location: " + Employee.companyLocation);
            Console.WriteLine("-----------------------------------------------");
        }

        //CaluculateBonus
        public void DisplayGrossSalaryWithBonus()
        {
            Console.WriteLine("Employee Id: " + empId);
            if (empPerformanceType == 'A')
            {
                Console.WriteLine("25%");
                Console.WriteLine(_empSalary + (_empSalary * 25 / 100));
            }
            else if (empPerformanceType == 'B')
            {
                Console.WriteLine("15%");
                Console.WriteLine(_empSalary + (_empSalary * 15 / 100));
            }
            else if (empPerformanceType == 'C')
            {
                Console.WriteLine("10%");
                Console.WriteLine(_empSalary + (_empSalary * 10 / 100));
            }
            else
            {
                Console.WriteLine("Not Eligible for Bonus!!!");
            }
            Console.WriteLine("-----------------------------------------------");
        }

        //public static Employee GetEmployeeInstance()
        //{
        //    Employee employee = new Employee();
        //    return employee;
        //}
    }
}
