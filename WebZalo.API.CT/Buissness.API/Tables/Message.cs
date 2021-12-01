using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ctchat.Data.Tables
{
    public class Message
    {
        [Key]
        public long MessId { get; set; }

        [ForeignKey("Id")]
        public long userId { get; set; }

        [ForeignKey("RoomId")]
        public long roomId { get; set; }

        [Required]
        public string value { get; set; }

        [Required]
        public DateTime createDate { get; set; }

        public virtual User userId { get; set; }
        public virtual Room roomId{ get; set; }
    }
}
