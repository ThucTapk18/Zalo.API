using System.ComponentModel.DataAnnotations;

namespace Ctchat.Data.Tables
{
    public class Room
    {
        [Key]
        public long RoomId  { get; set; }

        [Required]
        [StringLength(50)]
        public string roomName { get; set; }
    }
}
