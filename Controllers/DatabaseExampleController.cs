using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using In_Class_API_Consumption.DataAccess;
using In_Class_API_Consumption.Models;

namespace In_Class_API_Consumption.Controllers
{
    public class DatabaseExampleController : Controller
    {
        // Need a Database connection: define a property
        public ApplicationDbContext dbContext;
        // Build the Contsructor. The construction has a dependency called Dependency Injection.ApplicationDbContext: 
        public DatabaseExampleController(ApplicationDbContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
