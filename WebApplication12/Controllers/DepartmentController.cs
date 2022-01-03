using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            IList<Department> depart = new List<Department>();
            depart.Add(new Department() { DeptID = 1234, DeptName = "MCA", DeptLoc = "BGR" });
            depart.Add(new Department() { DeptID = 12, DeptName = "CA", DeptLoc = "SGH" });

            depart.Add(new Department() { DeptID = 1, DeptName = "ECA", DeptLoc = "BBSR" });
            ViewData["depart"] = depart;



            return View();
        }
    }
}
