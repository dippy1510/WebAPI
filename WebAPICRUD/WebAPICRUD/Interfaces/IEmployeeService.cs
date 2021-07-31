using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICRUD.Models;

namespace WebAPICRUD
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
        Employee AddEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
    }
}
