using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WEB_APP.Models
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public SQLEmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public Employee GetEmployee(int Id)
        {
            var employee = _context.Employees.FirstOrDefault(emp => emp.Id == Id);
            if (employee != null)
            {
                return employee;
            }

            throw new Exception("Cannot find the employee");
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee UpdateEmployee(Employee employeeChanges)
        {
            var employee = _context.Employees.Attach(employeeChanges);
            employee.State = EntityState.Modified;
            _context.SaveChanges();
            return employeeChanges;
        }

        public Employee DeleteEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
            return employee;
        }
    }
}
