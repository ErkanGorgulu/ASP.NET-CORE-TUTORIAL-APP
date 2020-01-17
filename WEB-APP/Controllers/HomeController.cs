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
        private IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public string Index()
        {

            return _employeeRepository.GetEmployee(1).Name;
        }
    }
}
