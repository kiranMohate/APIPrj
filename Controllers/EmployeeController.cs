using FirstApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly FISContext db;

        public EmployeeController(FISContext _db)
        {
            db = _db;
        }

        [HttpGet]
        public ActionResult<List<Employee>> getEmployee()
        {
            return Ok(db.Employees.ToList());
        }
        [HttpGet]
        [Route("GetByEmpID")]
        public ActionResult<Employee> GetByID(int? id)
        {
            var e=db.Employees.Find(id);
            return Ok(e);
        }

        [HttpPost]
        [Route("AddEmployee")]
        public ActionResult AddNewEmployee(Employee e)
        {
            db.Employees.Add(e);
            db.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteEmp(int id)
        {
            var e=db.Employees.Find(id);
            db.Employees.Remove(e);
            db.SaveChanges();
            return Ok();
        }
    }
}
