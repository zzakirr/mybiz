using System.ComponentModel.DataAnnotations;

namespace MyMy.Models
{
    public class Service
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(250)]

        public string Desc { get; set; }
        [MaxLength(100)]

        public string Icon { get; set; }


    }
}
