using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetProject.Data;
using PetProject.Data.Migrations;
using PetProject.Areas.Identity;

namespace PetProject.Controller
{
    //TODO rename name pages TableEmployeesController -> ListEmployeesController
    [Route("api/[controller]")]
    [ApiController]
    public class TableEmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TableEmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Find employees in table. 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<TableEmployees?> Get()
        {
            return _context.TableEmployees;
        }
        /// <summary>
        /// Find employees in table by ID. 
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public TableEmployees? Get(int id)
        {
            return _context.TableEmployees.FirstOrDefault(x => x.Id == id);
        }
        /// <summary>
        /// Add new employees in table. 
        /// </summary>
        /// <returns></returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>
        [HttpPost]
        public void Post([FromBody] TableEmployees? tableEmployees)
        {
            if (tableEmployees != null) _context.TableEmployees.Add(tableEmployees);
            _context.SaveChanges();
        }
        /// <summary>
        /// Update employees in table by ID. 
        /// </summary>
        /// <returns></returns>
        [HttpPut("{id:int}")]
        public void Put(int id, [FromBody] TableEmployees tableEmployees)
        {
            var tableEmploymentDb = _context.TableEmployees.Find(id);
            if (tableEmploymentDb != null)
            {
                tableEmploymentDb.FirstName = tableEmployees.FirstName;
                tableEmploymentDb.LastName = tableEmployees.LastName;
                tableEmploymentDb.SurName = tableEmployees.SurName;
                tableEmploymentDb.JobTitel = tableEmployees.JobTitel;

                _context.TableEmployees.Update(tableEmploymentDb);
            }

            _context.SaveChanges();
        }
        /// <summary>
        /// Delete employees in table by ID. 
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public void Delete(int id)
        {
            var tableEmploymentDb = _context.TableEmployees.Find(id);
            if (tableEmploymentDb != null) _context.TableEmployees.Remove(tableEmploymentDb);
            _context.SaveChanges();
        }
    }

}
