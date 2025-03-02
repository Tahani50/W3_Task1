using EmployeeSystem.Models;
using EmployeeSystem.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.Controllers
{ 
    public class EmployeesController : Controller
    {
        private readonly AppDbContext context;

        public EmployeesController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var employees = context.Employees.OrderByDescending(p => p.Id).ToList();
            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeDetails employeeDetails)
        {
            if (!ModelState.IsValid)
            {
                return View(employeeDetails);
            }

            Employee employee = new Employee()
            {
                Name = employeeDetails.Name,
                Position = employeeDetails.Position,
                Salary = employeeDetails.Salary,
            };

            context.Employees.Add(employee);
            context.SaveChanges();

            return RedirectToAction("Index", "Employees");
        }

        public IActionResult Edit(int id)
        {
            var employee = context.Employees.Find(id);

            if(employee == null)
            {
                return RedirectToAction("Index", "Employees");
            }

            var employeeDetails = new EmployeeDetails() { 
                Name = employee.Name,
                Salary = employee.Salary,
                Position = employee.Position,
            };

            ViewData["EmployeeId"] = employee.Id;

            return View(employeeDetails);
        }

        [HttpPost]
        public IActionResult Edit(int id, EmployeeDetails employeeDetails)
        {
            var employee = context.Employees.Find(id);

            if (employee == null)
            {
                return RedirectToAction("Index", "Employees");
            }

            if (!ModelState.IsValid)
            {
                ViewData["EmployeeId"] = employee.Id;
                return View(employeeDetails);
            }

            employee.Name = employeeDetails.Name;
            employee.Salary = employeeDetails.Salary;
            employee.Position = employeeDetails.Position;

            context.SaveChanges();

            return RedirectToAction("Index", "Employees");
        }

        public IActionResult Delete(int id)
        {
            var employee = context.Employees.Find(id);

            if (employee == null)
            {
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken] 
        public IActionResult DeleteConfirmed(int id)
        {
            var employee = context.Employees.Find(id);

            if (employee == null)
            {
                return RedirectToAction("Index");
            }

            context.Employees.Remove(employee);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
