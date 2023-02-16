using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace API.Domain
{
    /// <summary>
    /// Each user can have one player per server and each player can have multiple bases.
    /// TODO: Once researches and units are added, create a unit and research that should be attained before a player can create a new base. Before allowing a user to create the unit that unlocks a new base, ensure that the research has been attained on all bases and that none of the bases have the unit in-stock or in production.
    /// </summary>
    public class Base
    {
        public Base(string name) 
        {
            Name = name;
        }

        public Base(string name, int baseX, int baseY)
        {
            Name = name;
            BaseX = baseX;
            BaseY = baseY;
        }

        public Base(string name, string description)
        {
            Name = name;
            Description = description;
        }

        /// <summary>
        /// The unique base-id.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Bases should have names that are unique only on the player level.
        /// TODO: Once players are added, add validation to ensure players can't use the same base-name twice.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// A base description that can optionally be set by the player.
        /// </summary>
        [MaxLength(200)]
        public string? Description { get; set; } = null!;

        /// <summary>
        /// Base X position. Every server map will consist of X, Y plots.
        /// </summary>
        [DefaultValue(1)]
        public int BaseX { get; set; }

        /// <summary>
        /// Base Y position. Every server map will consist of X, Y plots.
        /// </summary>
        [DefaultValue(1)]
        public int BaseY { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// The resources currently existing on the base.
        /// </summary>
        public virtual ResourceStore? Resources { get; set; } = null!;

        /// <summary>
        /// The resource-production buildings on the base.
        /// TODO: Rename ResourceItem to ResourceBuilding, create a lookup table that holds the building levels and associated costs.
        /// </summary>
        public virtual ICollection<ResourceItem>? ResourceBuildings { get; set; } = null!;

        /// <summary>
        /// The non-production buildings on the base.
        /// TODO: Create a lookup table that holds the building levels and associated costs.
        /// </summary>
        public virtual ICollection<Building>? Buildings { get; set; } = null!;
    }
}
