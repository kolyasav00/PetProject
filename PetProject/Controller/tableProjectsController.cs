using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetProject.Areas.Identity;
using PetProject.Data;

namespace PetProject.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    //TODO rename name pages TableProjectsController -> ListProjectsController
    public class TableProjectsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TableProjectsController(ApplicationDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Find project in table. 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<TableProjects?> Get()
        {
            return _context.TableProjects;
        }
        /// <summary>
        /// Find project in table by ID. 
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public TableProjects? Get(int id)
        {
            return _context.TableProjects.FirstOrDefault(x => x.Id == id);
        }
        /// <summary>
        /// Add new project in table. 
        /// </summary>
        /// <returns></returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>
        [HttpPost]
        public void Post([FromBody] TableProjects? tableProjects)
        {
            if (tableProjects != null) _context.TableProjects.Add(tableProjects);
            _context.SaveChanges();
        }
        /// <summary>
        /// Update project in table by ID. 
        /// </summary>
        /// <returns></returns>
        [HttpPut("{id:int}")]
        public void Put(int id, [FromBody] TableProjects tableProjects)
        {
            var tableProjectFromDb = _context.TableProjects.Find(id);
            if (tableProjectFromDb != null)
            {
                tableProjectFromDb.Name = tableProjects.Name;
                tableProjectFromDb.Disctiption = tableProjects.Disctiption;

                _context.TableProjects.Update(tableProjectFromDb);
            }

            _context.SaveChanges();
        }
        /// <summary>
        /// Delete project in table by ID. 
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public void Delete(int id)
        {
            _context.TableProjects.Find(id);
            _context.SaveChanges();
        }
    }
}
