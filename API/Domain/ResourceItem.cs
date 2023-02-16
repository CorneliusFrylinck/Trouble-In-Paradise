using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Domain
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

        public ResourceItem(string name, string description, int level, int productionSpeed, int baseId)
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
            BaseId = baseId;
            Level = level;
            Description = description;
        }

        public ResourceItem(string name, string description, int level, int productionSpeed, int baseId, int id)
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
            BaseId = baseId;
            Id = id;
            Level = level;
            Description = description;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Resource building names are set by the server.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Resource building descriptions are set by the server.
        /// </summary>
        public string? Description { get; set; } = null!;

        /// <summary>
        /// Players should upgrade player buildings to increase their production speeds.
        /// </summary>
        public int Level { get; set; } = 0;
        [Required]
        public int ProductionSpeed { get; set; }

        /// <summary>
        /// Enum used to keep track of the resource type within the API to avoid errors caused by hard-coding.
        /// </summary>
        [Required]
        public ResourceEnum Type { get; set; }

        /// <summary>
        /// Multiple resource buildings are linked to one base.
        /// </summary>
        public int BaseId { get; set; }
    }
}
