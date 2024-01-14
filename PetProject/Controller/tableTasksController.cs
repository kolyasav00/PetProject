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
    public class TableTasksController : ControllerBase
    {
        public readonly ApplicationDbContext Context;

        private TableTasksController(ApplicationDbContext context) => Context = context;

        [HttpGet]
        public IEnumerable<TableTasks?> Get() => Context.tableTasks;

        [HttpGet("{id:int}")]
        public TableTasks? Get(int id) => Context.tableTasks.FirstOrDefault(x => x != null && x.Id == id);

        [HttpPost]
        public void Post([FromBody] TableTasks? tableTasks)
        {
            Context.tableTasks.Add(tableTasks);
            Context.SaveChanges();
        }

        [HttpPut("{id:int}")]
        public void Put(int id, [FromBody] TableTasks tableTasks)
        {
            var tableTasksFromDb = Context.tableTasks.Find(id);
            if (tableTasksFromDb != null)
            {
                tableTasksFromDb.Status = tableTasks.Status;
                tableTasksFromDb.NameTask = tableTasks.NameTask;
                tableTasksFromDb.NameProject = tableTasks.NameProject;
                tableTasksFromDb.Work = tableTasks.Work;
                tableTasksFromDb.DateStart = tableTasks.DateStart;
                tableTasksFromDb.DateEnd = tableTasks.DateEnd;
                tableTasksFromDb.Performer = tableTasks.Performer;

                Context.tableTasks.Update(tableTasksFromDb);
            }

            Context.SaveChanges();
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var tabelTasksFromDb = Context.tableTasks.Find(id);
            if (tabelTasksFromDb != null) Context.tableTasks.Remove(tabelTasksFromDb);
            Context.SaveChanges();
        }
    }
}
