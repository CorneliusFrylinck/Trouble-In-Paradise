using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Domain
{
    public class ResourceItem
    {
        public ResourceItem(string name)
        {
            Name = name;
            Type = GetType(name);
        }

        public ResourceItem(string name, int level, int productionSpeed)
        {
            Name = name;
            Type = GetType(name);
            ProductionSpeed = productionSpeed;
            Level = level;
        }

        public ResourceItem(string name, int level, int productionSpeed, int baseId)
        {
            Name = name;
            Type = GetType(name);
            ProductionSpeed = productionSpeed;
            BaseId = baseId;
            Level = level;
        }

        public ResourceItem(string name, int level, int productionSpeed, int baseId, int id)
        {
            Name = name;
            Type = GetType(name);
            ProductionSpeed = productionSpeed;
            BaseId = baseId;
            Id = id;
            Level = level;
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
        /// Players should upgrade player buildings to increase their production speeds.
        /// </summary>
        public int Level { get; set; } = 0;
        [Required]
        public double ProductionSpeed { get; set; }

        /// <summary>
        /// Enum used to keep track of the resource type within the API to avoid errors caused by hard-coding.
        /// </summary>
        [Required]
        public ResourceEnum Type { get; set; }

        /// <summary>
        /// Multiple resource buildings are linked to one base.
        /// </summary>
        public int BaseId { get; set; }

        private ResourceEnum GetType(string name)
        {
            switch (Name)
            {
                case "Cement": return ResourceEnum.Cement; 
                case "Blue_Crystal": return ResourceEnum.Blue_Crystal;
                case "Red_Crystal": return ResourceEnum.Red_Crystal;
                case "Metal": return ResourceEnum.Metal;
                case "Water": return ResourceEnum.Water;
                case "Food": return ResourceEnum.Food;
                case "Oxygen": return ResourceEnum.Oxygen;
                case "Gold": return ResourceEnum.Gold;
                case "Lumber": return ResourceEnum.Lumber;
            }

            return ResourceEnum.Cement;
        }
    }
}
