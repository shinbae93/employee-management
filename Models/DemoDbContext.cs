using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
  public class DemoDbContext : DbContext
  {
    public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options) { }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
  }
}