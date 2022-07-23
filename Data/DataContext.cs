using System;
using Alliance.Models;
using Microsoft.EntityFrameworkCore;

namespace Alliance.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}

