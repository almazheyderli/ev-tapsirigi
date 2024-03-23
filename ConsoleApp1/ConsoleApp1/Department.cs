using Almazmethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmazMethods
{
    internal class Department
    {
        public Employee[] Employees;
        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length - 1);
        }
        public void ShowEmployeeInfo()
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                Employee employee = Employees[i];
                Console.WriteLine($"{employee.Name} {employee.Surname} Age:{employee.Age},DepartmentNo{employee.DepartmentNo},Salary{employee.Salary}");
            }
        }
        public Employee[] GetAllEmployees()
        {
            return Employees;
        }
        public Employee[] GetAllEmployeesBySalary(decimal minSalary,decimal maxSalary)

        {
            Employee[] result = new Employee[Employees.Length];
           foreach(Employee employee in Employees)
            {
                if(employee.Salary > minSalary & employee.Salary < maxSalary)
                {
                    Array.Resize(ref result, Employees.Length - 1);

                }
            }
           return result;

        }

}
