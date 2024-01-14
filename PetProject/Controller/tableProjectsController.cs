using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetProject.Areas.Identity;
using PetProject.Data;

namespace PetProject.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableProjectsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TableProjectsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<TableProjects?> Get()
        {
            return _context.tableProjects;
        }
        [HttpGet("{id:int}")]
        public TableProjects? Get(int id)
        {
            return _context.tableProjects.FirstOrDefault(x => x.Id == id);
        }
        [HttpPost]
        public void Post([FromBody] TableProjects? tableProjects)
        {
            _context.tableProjects.Add(tableProjects);
            _context.SaveChanges();
        }
        [HttpPut("{id:int}")]
        public void Put(int id, [FromBody] TableProjects tableProjects)
        {
            var tableProjectFromDb = _context.tableProjects.Find(id);
            tableProjectFromDb.Name = tableProjects.Name;
            tableProjectFromDb.Disctiption = tableProjects.Disctiption;

            _context.tableProjects.Update(tableProjectFromDb);
            _context.SaveChanges();
        }
        [HttpDelete]
        public void Delete(int id)
        {
            _context.tableProjects.Find(id);
            _context.SaveChanges();
        }
    }
}
