using CodeFirst.Data;
using CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.Controllers
{
    [ApiController]
    [Route("/")]
    public class EmployeeController : ControllerBase
    {
        private readonly CompanyDBContext db;
        public EmployeeController(CompanyDBContext companyDBContext) : base()
        {
            db = companyDBContext;
        }
        public List<Employee> getEmployees()
        {
            return db.employee.Where(e => e.gender == true && e.age >= 30 && e.age <= 40 && e.department.name == "Marketing").ToList();
        }
    }
    }
