using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GigaWebMvc.Models;

namespace GigaWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Bebidas" });
            list.Add(new Department { Id = 2, Name = "Salgadinhos" });
            list.Add(new Department { Id = 3, Name = "Congelados" });
            list.Add(new Department { Id = 4, Name = "Doces" });


            return View(list);
        }
    }
}