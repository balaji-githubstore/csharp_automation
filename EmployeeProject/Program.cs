
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


            Employee emp1=new Employee();
            Employee emp2=new Employee();


            emp1.empId = 101;
            emp1.empName = "Saul";
            emp1.empSalary = 9000;

            emp2.empId = 102;
            emp2.empName = "Kim";
            emp2.empSalary = 12000.2;

            


            Employee.companyName = "Maveric Company";

            Console.WriteLine(emp1.empId);

            Console.WriteLine(emp2.empId);
       
        }

    }
}