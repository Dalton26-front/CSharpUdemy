using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SallesWebApi.Models;

namespace SallesWebApi.Data
{
    public class SallesWebApiContext : DbContext
    {
        public SallesWebApiContext (DbContextOptions<SallesWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<SallesWebApi.Models.Department> Department { get; set; }
    }
}
