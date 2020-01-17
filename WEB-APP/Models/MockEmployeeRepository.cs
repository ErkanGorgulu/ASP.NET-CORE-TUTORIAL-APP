﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_APP.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees;

        public MockEmployeeRepository()
        {
            _employees = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Erkan", Email = "erkangorgulu@gmail.com", Department = "IT"},
                new Employee() {Id = 2, Name = "Steve", Email = "djsteve@hotmail.com", Department = "HR"},
                new Employee() {Id = 3, Name = "Laila", Email = "crazy_laila@hotmail.com", Department = "Accountancy"}
            };
        }
        public Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }
    }
}