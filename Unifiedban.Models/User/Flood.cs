using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.User
{
    [Table("User_Flood", Schema = "dbo")]
    public class Flood
    {
        [Key]
        public int TelegramUserId { get; set; }
        [Key]
        public string GroupId { get; set; }
        public virtual Group.TelegramGroup Group { get; set; }
        public DateTime UtcDate { get; set; }
        [NotMapped]
        public int MessageCount { get; set; }

    }
}
