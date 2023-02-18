using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Domain
{
    public class Description
    {
        public Description(TargetTypeEnum type, string name, string value)
        {
            Type = type;
            Name = name;
            Value = value;
        }
        public Description(TargetTypeEnum type, string name, string value, int id)
        {
            Type = type;
            Name = name;
            Value = value;
            Id = id;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public TargetTypeEnum Type { get; set; }
        public string Name { get; set; }
        public string Value { get; set; } = null!;
    }
}
