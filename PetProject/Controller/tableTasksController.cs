using System.Collections.Generic;
using System.Linq;
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
        private readonly ApplicationDbContext _context;

        public TableTasksController(ApplicationDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Find task in table. 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<TableTasks?> Get() => _context.TableTasks;
        /// <summary>
        /// Find task in table by ID. 
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public TableTasks? Get(int id) => _context.TableTasks.FirstOrDefault(x => x != null && x.Id == id);
        /// <summary>
        /// Add new task in table. 
        /// </summary>
        /// <returns></returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>
        [HttpPost]
        public void Post([FromBody] TableTasks? tableTasks)
        {
            if (tableTasks != null) _context.TableTasks.Add(tableTasks);
            _context.SaveChanges();
        }
        /// <summary>
        /// Update task in table by ID. 
        /// </summary>
        /// <returns></returns>
        [HttpPut("{id:int}")]
        public void Put(int id, [FromBody] TableTasks tableTasks)
        {
            var tableTasksFromDb = _context.TableTasks.Find(id);
            if (tableTasksFromDb != null)
            {
                tableTasksFromDb.Status = tableTasks.Status;
                tableTasksFromDb.NameTask = tableTasks.NameTask;
                tableTasksFromDb.NameProject = tableTasks.NameProject;
                tableTasksFromDb.Work = tableTasks.Work;
                tableTasksFromDb.DateStart = tableTasks.DateStart;
                tableTasksFromDb.DateEnd = tableTasks.DateEnd;
                tableTasksFromDb.Performer = tableTasks.Performer;

                _context.TableTasks.Update(tableTasksFromDb);
            }

            _context.SaveChanges();
        }
        /// <summary>
        /// Delete task in table by ID. 
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public void Delete(int id)
        {
            var tableTasksFromDb = _context.TableTasks.Find(id);
            if (tableTasksFromDb != null) _context.TableTasks.Remove(tableTasksFromDb);
            _context.SaveChanges();
        }
    }
}
