using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetProject.Data;
using PetProject.Data.Migrations;
using PetProject.Areas.Identity;

namespace PetProject.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class tableEmployeesController : ControllerBase
    {
        private ApplicationDbContext _context;

        public tableEmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<TableEmployees> Get()
        {
            return _context.tableEmployees;
        }
        [HttpGet("{id}")]
        public TableEmployees Get(int id)
        {
            return _context.tableEmployees.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public void Post([FromBody] TableEmployees tableEmployees)
        {
            _context.tableEmployees.Add(tableEmployees);
            _context.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TableEmployees tableEmployees)
        {
            var tableEmployeesfromDB = _context.tableEmployees.Find(id);
            tableEmployeesfromDB.FirstName = tableEmployees.FirstName;
            tableEmployeesfromDB.LastName = tableEmployees.LastName;
            tableEmployeesfromDB.SurName = tableEmployees.SurName;
            tableEmployeesfromDB.jobTitel = tableEmployees.jobTitel;

            _context.tableEmployees.Update(tableEmployeesfromDB);
            _context.SaveChanges();
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var tableEmployeesfromDB = _context.tableEmployees.Find(id);
            _context.tableEmployees.Remove(tableEmployeesfromDB);
            _context.SaveChanges();
        }
    }

}
