using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Data
{
    [Table("CLIENTS")]
    public class Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string passwd { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        public string phone { get; set; }
        [Required]
        public string date { get; set; }

    }
}
