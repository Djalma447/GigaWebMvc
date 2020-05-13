using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GigaWebMvc.Models;

namespace GigaWebMvc.Data
{
    public class GigaWebMvcContext : DbContext
    {
        public GigaWebMvcContext (DbContextOptions<GigaWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<GigaWebMvc.Models.Department> Department { get; set; }
    }
}
