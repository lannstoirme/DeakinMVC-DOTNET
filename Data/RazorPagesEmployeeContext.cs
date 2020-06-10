using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeakinRazorPages.Models;

    public class RazorPagesEmployeeContext : DbContext
    {
        public RazorPagesEmployeeContext (DbContextOptions<RazorPagesEmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<DeakinRazorPages.Models.Employee> Employee { get; set; }
    }
