using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICRUD.Models;

namespace WebAPICRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _employeeData;

        public EmployeeController(IEmployeeService employeeData)
        {
            _employeeData = employeeData;
        }



        [HttpGet]
        public IActionResult GetEmployee()
        {
            return Ok(_employeeData.GetAllEmployees());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetAllEmployee(int id)
        {
            return Ok(_employeeData.GetEmployee(id));
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            var emp = _employeeData.AddEmployee(employee);

            if (emp != null)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateEmployee(int id, Employee employee)
        {
            if (employee != null)
            {
                employee.EmployeeID = id;
                _employeeData.UpdateEmployee(employee);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete]
        public IActionResult DeleteEmployee(Employee employee)
        {
            if (employee != null)
            {
                _employeeData.DeleteEmployee(employee);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
