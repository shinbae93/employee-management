using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
  public class EmployeeService : IEmployeeService
  {
    private readonly DemoDbContext _demoDbContext;
    public EmployeeService(DemoDbContext demoContext) 
    {
      _demoDbContext = demoContext;
    }

    public void CreateDepartment(Department department)
    {
      _demoDbContext.Departments.Add(department);
      _demoDbContext.SaveChanges();
    }

    public void CreateEmployee(Employee employee)
    {
      _demoDbContext.Employees.Add(employee);
      _demoDbContext.SaveChanges();
    }

    public void DeleteDepartment(int id)
    {
      var department = _demoDbContext.Departments.FirstOrDefault(d => d.Id == id); 
      _demoDbContext.Remove(department);
      _demoDbContext.SaveChanges();
    }

    public void DeleteEmployee(int id)
    {
      var employee = _demoDbContext.Employees.FirstOrDefault(e => e.Id == id);
      _demoDbContext.Employees.Remove(employee);
      _demoDbContext.SaveChanges();
    }

    public Department? GetDepartment(int id)
    {
      return _demoDbContext.Departments.FirstOrDefault(d => d.Id == id);
    }

    public List<Department> GetDepartments()
    {
      return _demoDbContext.Departments.ToList();
    }

    public Employee? GetEmployee(int id)
    {
      return _demoDbContext.Employees.FirstOrDefault(e => e.Id == id);
    }

    public List<Employee> GetEmployees()
    {
      return _demoDbContext.Employees.ToList();
    }

    public void UpdateDepartment(Department department)
    {
      Department? newDepartment = _demoDbContext.Departments.FirstOrDefault(e => e.Id == department.Id);
      newDepartment.Name = department.Name;
      _demoDbContext.SaveChanges();
    }

    public void UpdateEmployee(Employee employee)
    {
      Employee? newEmployee = _demoDbContext.Employees.FirstOrDefault(e => e.Id == employee.Id); 
      newEmployee.Name = employee.Name;
      newEmployee.Gender = employee.Gender;
      newEmployee.Email = employee.Email;
      newEmployee.PhoneNumber = employee.PhoneNumber;
      newEmployee.DepartmentId = employee.DepartmentId;
      _demoDbContext.SaveChanges();
    }
  }
}