using System.ComponentModel.DataAnnotations.Schema;

namespace PetProject.Areas.Identity
{
    [Table("TableEmployees", Schema = "data")]
    public class TableEmployees
    {
        public TableEmployees(string lastName, string firstName, string surName, string jobTitel)
        {
            LastName = lastName;
            FirstName = firstName;
            SurName = surName;
            JobTitel = jobTitel;
        }

        public int Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string SurName { get; set; }

        public string JobTitel { get; set; }
    }
}
