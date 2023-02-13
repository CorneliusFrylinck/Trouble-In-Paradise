using System.Numerics;

namespace API.Models
{
    public class Base
    {
        public Base(string name) 
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; } = null!;
        public Vector2 Position { get; set; }
        public ResourceStore Resources { get; set; }
        public ICollection<ResourceItem> ResourceBuildings { get; set; } = new List<ResourceItem>();
    }
}
