using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICRUD.Models;

namespace WebAPICRUD.Classes
{
    public class EmployeeService : IEmployeeService
    {
        private EmployeeContext _employeeContext;

        public EmployeeService(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }


        public Employee AddEmployee(Employee employee)
        {
            _employeeContext.Employee.Add(employee);
            _employeeContext.SaveChanges();

            if (employee.EmployeeID > 0)
            {
                return employee;
            }
            else
            {
                return null;
            }
        }

        public void DeleteEmployee(Employee employee)
        {
            try
            {
                var emp = _employeeContext.Employee.Find(employee.EmployeeID);

                if (emp != null)
                {
                    _employeeContext.Employee.Remove(emp);
                    _employeeContext.SaveChanges();
                }
            }
            catch
            { }
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeContext.Employee.ToList();
        }

        public Employee GetEmployee(int id)
        {
            return _employeeContext.Employee.SingleOrDefault(emp => emp.EmployeeID == id);
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var emp = _employeeContext.Employee.Find(employee.EmployeeID);

            if (emp != null)
            {
                emp.EmployeeName = employee.EmployeeName;
                emp.EmployeeDesignation = employee.EmployeeDesignation;
                emp.EmployeeLocation = employee.EmployeeLocation;

                _employeeContext.Employee.Update(emp);
                _employeeContext.SaveChanges();
            }

            return employee;
        }
    }
}
