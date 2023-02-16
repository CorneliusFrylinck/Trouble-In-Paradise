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

        /// <summary>
        /// Building names are set by the server.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Building descriptions are set by the server.
        /// </summary>

        public string Description { get; set; }

        /// <summary>
        /// Users must level up buildings to unlock new funcitonality.
        /// TODO: Add a lookup table for the functionalities to unlock.
        /// </summary>

        public int Level { get; set; } = 0;

        /// <summary>
        /// Multiple buildings are linked to one base.
        /// </summary>

        public int BaseId { get; set; }
    }
}
