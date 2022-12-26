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
        public double empSalary;
        public static string companyName; //static variable or class variable 
        public static string companyLocation;


        public void PrintEmployeeDetail()
        {
            Console.WriteLine("Employee Id: "+empId);
            Console.WriteLine("Employee Name: "+empName);
            Console.WriteLine("Employee Salary: "+empSalary);
            Console.WriteLine("Company Name: "+Employee.companyName);
            Console.WriteLine("Company Location: "+Employee.companyLocation);
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
