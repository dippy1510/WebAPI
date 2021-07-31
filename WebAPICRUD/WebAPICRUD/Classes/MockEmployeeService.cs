using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICRUD.Models;

namespace WebAPICRUD.Classes
{
    public class MockEmployeeService : IEmployeeService
    {
        private List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                EmployeeID = 1,
                EmployeeName = "Dilpreet Singh",
                EmployeeDesignation = "SSD"
            },
            new Employee
            {
                EmployeeID = 2,
                EmployeeName = "Latha N",
                EmployeeDesignation = "TL"
            }
        };
        public Employee AddEmployee(Employee employee)
        {
            employee.EmployeeID = 3;

            employees.Add(employee);
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public Employee GetEmployee(int id)
        {
            return employees.SingleOrDefault(i => i.EmployeeID == id);
        }

        public Employee UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
