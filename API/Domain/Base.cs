using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace API.Domain
{
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

        public Base(string name, string description, int baseX, int baseY)
        {
            Name = name;
            Description = description;
            BaseX = baseX;
            BaseY = baseY;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; } = null!;
        [Required]
        public int BaseX { get; set; }
        [Required]
        public int BaseY { get; set; }
        [Required]
        public ResourceStore Resources { get; set; } = new ResourceStore();
        [Required]
        public ICollection<ResourceItem> ResourceBuildings { get; set; } = new List<ResourceItem>();
        [Required]
        public ICollection<Building> Buildings { get; set; } = new List<Building>();
    }
}
