using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEB_APP.Models;

namespace WEB_APP.Controller
{
    public class HomeController: Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public string Index(int id=1)
        {

            return _employeeRepository.GetEmployee(Id:id).Name;
        }
        public ViewResult Details(int id=1)
        {

            Employee employee = _employeeRepository.GetEmployee(Id:id);
            return View(employee);
        }
    }
}
