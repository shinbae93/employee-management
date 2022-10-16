using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
  public class Employee
  {
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool Gender { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public int DepartmentId { get; set; }
    public virtual Department? Department { get; set; }
  }
}