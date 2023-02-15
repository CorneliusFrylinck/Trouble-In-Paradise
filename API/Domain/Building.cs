using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API.Domain
{
    public class Building
    {
        public Building(string name, string description, int level)
        {
            Name = name;
            Description = description;
            Level = level;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; } = 0;
    }
}
