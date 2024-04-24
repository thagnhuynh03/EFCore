using DataFirst.Repository;
using DataFirst.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataFirst.Controllers
{
    [ApiController]
    [Route("/")]
    public class EmployeeController : ControllerBase
    {
        private readonly CompanyDbContext db;
        public EmployeeController(CompanyDbContext companyDBContext) : base()
        {
            db = companyDBContext;
        }
        public List<Employee> getEmployees()
        {
            return db.Employees.Where(e => e.Gender ==true && e.Age >= 30 && e.Age <= 40 && e.Department.Name == "Marketing").ToList();
        }
    }
}
