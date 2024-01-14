using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetProject.Areas.Identity;
using PetProject.Data;

namespace PetProject.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class tableProjectsController : ControllerBase
    {
        private ApplicationDbContext _context;

        public tableProjectsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<TableProjects> Get()
        {
            return _context.tableProjects;
        }
        [HttpGet("{id}")]
        public TableProjects Get(int id)
        {
            return _context.tableProjects.FirstOrDefault(x => x.Id == id);
        }
        [HttpPost]
        public void Post([FromBody] TableProjects tableProjects)
        {
            _context.tableProjects.Add(tableProjects);
            _context.SaveChanges();
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TableProjects tableProjects)
        {
            var tableProjectFromDB = _context.tableProjects.Find(id);
            tableProjectFromDB.Name = tableProjects.Name;
            tableProjectFromDB.Disctiption = tableProjects.Disctiption;

            _context.tableProjects.Update(tableProjectFromDB);
            _context.SaveChanges();
        }
        [HttpDelete]
        public void Delete(int id)
        {
            var tableProjectFromDB = _context.tableProjects.Find(id);
            _context.SaveChanges();
        }
    }
}
