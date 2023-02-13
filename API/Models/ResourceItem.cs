using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class ResourceItem
    {
        public ResourceItem(string name)
        {
            Name = name;
            switch (Name)
            {
                case "Cement":          Type = ResourceEnum.Cement; break;
                case "Crystal_Blue":    Type = ResourceEnum.Crystal_Blue; break;
                case "Crystal_Red":     Type = ResourceEnum.Crystal_Red; break;
                case "Metal":           Type = ResourceEnum.Metal; break;
                case "Water":           Type = ResourceEnum.Water; break;
                case "Food":            Type = ResourceEnum.Food; break;
                case "Oxygen":          Type = ResourceEnum.Oxygen; break;
                case "Gold":            Type = ResourceEnum.Gold; break;
                case "Lumber":          Type = ResourceEnum.Lumber; break;
            }
        }

        public ResourceItem(string name, string description, int level, int productionSpeed)
        {
            Name = name;
            switch (Name)
            {
                case "Cement": Type = ResourceEnum.Cement; break;
                case "Crystal_Blue": Type = ResourceEnum.Crystal_Blue; break;
                case "Crystal_Red": Type = ResourceEnum.Crystal_Red; break;
                case "Metal": Type = ResourceEnum.Metal; break;
                case "Water": Type = ResourceEnum.Water; break;
                case "Food": Type = ResourceEnum.Food; break;
                case "Oxygen": Type = ResourceEnum.Oxygen; break;
                case "Gold": Type = ResourceEnum.Gold; break;
                case "Lumber": Type = ResourceEnum.Lumber; break;
            }
            ProductionSpeed = productionSpeed;
            Level = level;
            Description = description;
        }

        public ResourceItem(string name, string description, int level, int productionSpeed, int id)
        {
            Name = name;
            switch (Name)
            {
                case "Cement": Type = ResourceEnum.Cement; break;
                case "Crystal_Blue": Type = ResourceEnum.Crystal_Blue; break;
                case "Crystal_Red": Type = ResourceEnum.Crystal_Red; break;
                case "Metal": Type = ResourceEnum.Metal; break;
                case "Water": Type = ResourceEnum.Water; break;
                case "Food": Type = ResourceEnum.Food; break;
                case "Oxygen": Type = ResourceEnum.Oxygen; break;
                case "Gold": Type = ResourceEnum.Gold; break;
                case "Lumber": Type = ResourceEnum.Lumber; break;
            }
            ProductionSpeed = productionSpeed;
            Level = level;
            Description = description;
            Id = id;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; } = null!;
        public int Level { get; set; }
        public int ProductionSpeed { get; set; }
        public ResourceEnum Type { get; set; }
    }
}
