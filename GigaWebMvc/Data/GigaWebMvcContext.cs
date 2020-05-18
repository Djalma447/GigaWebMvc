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

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
