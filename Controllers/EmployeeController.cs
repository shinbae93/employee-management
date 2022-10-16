using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
  public class EmployeeController : Controller
  {
    private readonly ILogger<EmployeeController> _logger;
    private readonly IEmployeeService _employeeService;

    public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService employeeService)
    {
        _logger = logger;
      _employeeService = employeeService;
    }
    
    public IActionResult Index()
    {
      
      return View(_employeeService.GetEmployees());
    }
    public IActionResult Create()
    {
      return View(_employeeService.GetDepartments());
    }
    [HttpPost]
    public IActionResult Save(Employee employee)
    {
      _employeeService.CreateEmployee(employee);
      return View("Index", _employeeService.GetEmployees());
    }
    public IActionResult Get(int id)
    {
      ViewBag.Employee = _employeeService.GetEmployee(id);
      return View("Update",_employeeService.GetDepartments());
    }
    public IActionResult Update(Employee employee)
    {
      _employeeService.UpdateEmployee(employee);
      return View("Index", _employeeService.GetEmployees());
    }
    public IActionResult Delete(int id)
    {
      if(_employeeService.GetEmployee(id) == null)
      {
          return NotFound();
      }
      _employeeService.DeleteEmployee(id);
      return View("Index", _employeeService.GetEmployees());
    }
  }
}