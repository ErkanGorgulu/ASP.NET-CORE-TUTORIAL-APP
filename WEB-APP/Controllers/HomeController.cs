using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEB_APP.Models;
using WEB_APP.ViewModels;

namespace WEB_APP.Controller
{
    public class HomeController: Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        //[Route("")]
        //[Route("Home")]
        //[Route("Home/Index")]
        //attribute routing, use them for APIs
        public ViewResult Index()
        {
            ViewBag.Title = "Employee List";
            var employees = _employeeRepository.GetEmployees();
            return View(employees);
        }
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel
            {
                Employee = _employeeRepository.GetEmployee(id??1),//if null use 1
                PageTitle = "Details"
            };
            return View(homeDetailsViewModel);
        }
    }
}
