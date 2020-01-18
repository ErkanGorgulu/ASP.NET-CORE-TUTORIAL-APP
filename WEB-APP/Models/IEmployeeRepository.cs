using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_APP.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
        List<Employee> GetEmployees();
        Employee AddEmployee(Employee employee);
    }
}
