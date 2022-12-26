
using EmployeeProject;

namespace Maveric.Runner
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("************EMPLOYEE DASHBORD*****************");

            Employee.companyName = "Maveric";
            Employee.companyLocation = "Chennai";


            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();
            Employee emp4 = new Employee();


            emp1.empId = 101;
            emp1.empName = "Saul";
            //emp1.empSalary = -9000;
            emp1.empPerformanceType = 'B';
            //write using EmployeeSalary property
            emp1.EmployeeSalary = 9000;


            emp2.empId = 102;
            emp2.empName = "Kim";
            //emp2.empSalary = 12000.2;
            emp2.empPerformanceType = 'A';
            emp2.EmployeeSalary = -8900.2;

            emp3.empId = 103;
            emp3.empName = "Jack";
            //emp3.empSalary = 6000.2;
            emp3.empPerformanceType = 'C';
            emp3.EmployeeSalary = 45545.55;

            Employee.companyName = "Maveric Company";


            emp1.PrintEmployeeDetail();
            emp2.PrintEmployeeDetail();
            emp3.PrintEmployeeDetail();

            //   emp4.PrintEmployeeDetail();

            emp1.DisplayGrossSalaryWithBonus();
            emp2.DisplayGrossSalaryWithBonus();
            emp3.DisplayGrossSalaryWithBonus();
            emp4.DisplayGrossSalaryWithBonus();

            //read the EmployeeSalary property
            Console.WriteLine(emp3.EmployeeSalary);

        }

    }
}