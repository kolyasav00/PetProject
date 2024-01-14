using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetProject.Areas.Identity;
using PetProject.Data;
using PetProject.Data.Migrations;
using SQLitePCL;

namespace PetProject.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class tableTasksController : ControllerBase
    {
        private ApplicationDbContext _context;

        private tableTasksController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<TableTasks> Get() => _context.tableTasks;

        [HttpGet("{id}")]
        public TableTasks Get(int id) => _context.tableTasks.FirstOrDefault(x => x.Id == id);

        [HttpPost]
        public void Post([FromBody] TableTasks tableTasks)
        {
            _context.tableTasks.Add(tableTasks);
            _context.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TableTasks tableTasks)
        {
            var tableTasksFromDB = _context.tableTasks.Find(id);
            tableTasksFromDB.Status = tableTasks.Status;
            tableTasksFromDB.NameTask = tableTasks.NameTask;
            tableTasksFromDB.NameProject = tableTasks.NameProject;
            tableTasksFromDB.Work = tableTasks.Work;
            tableTasksFromDB.DateStart = tableTasks.DateStart;
            tableTasksFromDB.DateEnd = tableTasks.DateEnd;
            tableTasksFromDB.Performer = tableTasks.Performer;

            _context.tableTasks.Update(tableTasksFromDB);
            _context.SaveChanges();
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var tabelTasksFromDB = _context.tableTasks.Find(id);
            _context.tableTasks.Remove(tabelTasksFromDB);
            _context.SaveChanges();
        }
    }
}
