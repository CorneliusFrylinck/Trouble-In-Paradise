using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API.Domain
{
    /// <summary>
    /// The resources currently on a base.
    /// </summary>
    public class ResourceStore
    {
        public ResourceStore()
        {
            Metal = 3000;
            Cement = 3000;
            Lumber = 3000;
            Water = 3000;
            Food = 3000;
            Oxygen = 3000;
            Crystal_Blue = 3000;
            Crystal_Red = 3000;
            Gold = 1000;
        }
        public ResourceStore(int baseId)
        {
            Metal = 3000;
            Cement = 3000;
            Lumber = 3000;
            Water = 3000;
            Food = 3000;
            Oxygen = 3000;
            Crystal_Blue = 3000;
            Crystal_Red = 3000;
            Gold = 1000;
            BaseId = baseId;
        }
        public ResourceStore(int baseId, int id)
        {
            Metal = 3000;
            Cement = 3000;
            Lumber = 3000;
            Water = 3000;
            Food = 3000;
            Oxygen = 3000;
            Crystal_Blue = 3000;
            Crystal_Red = 3000;
            Gold = 1000;
            BaseId = baseId;
            Id = id;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Metal { get; set; }
        public int Cement { get; set; }
        public int Lumber { get; set; }
        public int Water { get; set; }
        public int Food { get; set; }
        public int Oxygen { get; set; }
        public int Crystal_Blue { get; set; }
        public int Crystal_Red { get; set; }
        public int Gold { get; set; }
        public int BaseId { get; set; }
    }
}
