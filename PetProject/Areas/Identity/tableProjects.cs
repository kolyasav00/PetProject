using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetProject.Areas.Identity
{
    [Table("tableProjects", Schema = "data")]
    public class TableProjects
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Disctiption { get; set; }

    }
}
