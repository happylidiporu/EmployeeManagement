using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EmployeeManagement.Controllers
{
    public class FirstController : Controller
    {
        private readonly IConfiguration configuration;
        public FirstController(IConfiguration config)
        {
            this.configuration = config;
        }
        public IActionResult Index()
        {
            string connectionstring = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Product", conn);
            var count = (int)cmd.ExecuteScalar();
            ViewData["TotalData"] = count;
            conn.Close();
            return View();
        }

        public IActionResult Welcome(string name, int totalTimes = 5)
        {
            ViewData["message"] = "hi, " + name;
            ViewData["totalTimes"] = totalTimes;
            return View();
        }
    }
}