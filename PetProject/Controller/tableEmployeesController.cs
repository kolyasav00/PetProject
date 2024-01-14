using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetProject.Data;
using PetProject.Data.Migrations;
using PetProject.Areas.Identity;

namespace PetProject.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableEmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TableEmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<TableEmployees?> Get()
        {
            return _context.tableEmployees;
        }
        [HttpGet("{id:int}")]
        public TableEmployees? Get(int id)
        {
            return _context.tableEmployees.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public void Post([FromBody] TableEmployees? tableEmployees)
        {
            _context.tableEmployees.Add(tableEmployees);
            _context.SaveChanges();
        }

        [HttpPut("{id:int}")]
        public void Put(int id, [FromBody] TableEmployees tableEmployees)
        {
            var tableEmployeesfromDb = _context.tableEmployees.Find(id);
            tableEmployeesfromDb.FirstName = tableEmployees.FirstName;
            tableEmployeesfromDb.LastName = tableEmployees.LastName;
            tableEmployeesfromDb.SurName = tableEmployees.SurName;
            tableEmployeesfromDb.jobTitel = tableEmployees.jobTitel;

            _context.tableEmployees.Update(tableEmployeesfromDb);
            _context.SaveChanges();
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var tableEmployeesfromDb = _context.tableEmployees.Find(id);
            _context.tableEmployees.Remove(tableEmployeesfromDb);
            _context.SaveChanges();
        }
    }

}
