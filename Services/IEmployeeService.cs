using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
  public interface IEmployeeService
  {
    List<Employee> GetEmployees();
    Employee? GetEmployee(int id);
    void CreateEmployee(Employee employee);
    void UpdateEmployee(Employee employee);
    void DeleteEmployee(int id);

    List<Department> GetDepartments();
    Department? GetDepartment(int id);
    void CreateDepartment(Department department);
    void UpdateDepartment(Department department);
    void DeleteDepartment(int id);
  }
}