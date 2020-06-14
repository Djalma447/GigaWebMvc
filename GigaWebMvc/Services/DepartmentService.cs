using GigaWebMvc.Data;
using GigaWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GigaWebMvc.Services
{
    public class DepartmentService
    {
        private readonly GigaWebMvcContext _context;

        public DepartmentService(GigaWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
