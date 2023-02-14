namespace API.Models
{
    public class Building
    {
        public Building(string name, string description, int level)
        {
            Name = name;
            Description = description;
            Level = level;
        }
        public Building(string name, string description, int level, int Id)
        {
            Name = name;
            Description = description;
            Level = level;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
    }
}
