using System.ComponentModel.DataAnnotations;

namespace Ctchat.Data.Tables
{
    public class User
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(10)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
