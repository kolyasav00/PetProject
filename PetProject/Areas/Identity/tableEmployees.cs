using System.ComponentModel.DataAnnotations.Schema;

namespace PetProject.Areas.Identity
{
    [Table("TableEmployees", Schema = "data")]
    public class TableEmployees
    {
        public int Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string SurName { get; set; }

        public string jobTitel { get; set; }
    }
}
