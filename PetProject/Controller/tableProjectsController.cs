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
            return _context.TableProjects;
        }
        [HttpGet("{id:int}")]
        public TableProjects? Get(int id)
        {
            return _context.TableProjects.FirstOrDefault(x => x.Id == id);
        }
        [HttpPost]
        public void Post([FromBody] TableProjects? tableProjects)
        {
            if (tableProjects != null) _context.TableProjects.Add(tableProjects);
            _context.SaveChanges();
        }
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
        [HttpDelete]
        public void Delete(int id)
        {
            _context.TableProjects.Find(id);
            _context.SaveChanges();
        }
    }
}
