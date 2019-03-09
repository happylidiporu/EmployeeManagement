using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Models;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
        }

        public JsonResult DetailsJson()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            return Json(model);
        }

        public ObjectResult DetailsObject()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            return new ObjectResult(model);
        }

        public ViewResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            ViewBag.PageTitle = "Employee Details";
            return View(model);
        }

        public ViewResult All()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            return View(model);
        }
    }
}