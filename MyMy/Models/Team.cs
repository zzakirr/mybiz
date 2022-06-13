using System.ComponentModel.DataAnnotations;

namespace MyMy.Models
{
    public class Team
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(100)]

        public string Position { get; set; }
        [MaxLength(250)]

        public string Desc { get; set; }
        [MaxLength(100)]

        public string Image { get; set; }

    }
}
