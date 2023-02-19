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
            Blue_Crystal = 3000;
            Red_Crystal = 3000;
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
            Blue_Crystal = 3000;
            Red_Crystal = 2000;
            Gold = 5000;
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
            Blue_Crystal = 3000;
            Red_Crystal = 2000;
            Gold = 5000;
            BaseId = baseId;
            Id = id;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double Metal { get; set; }
        public double Cement { get; set; }
        public double Lumber { get; set; }
        public double Water { get; set; }
        public double Food { get; set; }
        public double Oxygen { get; set; }
        public double Blue_Crystal { get; set; }
        public double Red_Crystal { get; set; }
        public double Gold { get; set; }
        public int BaseId { get; set; }
    }
}
