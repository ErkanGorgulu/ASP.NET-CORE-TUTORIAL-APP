using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_APP.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetEmployees();
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employeeChanges);
        Employee DeleteEmployee(int id);
    }
}
