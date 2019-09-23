using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.User
{
    [Table("User_TempKicked", Schema = "dbo")]
    public class TempKicked
    {
        public int TelegramUserId { get; set; }
        public string GroupId { get; set; }
        public virtual Group.TelegramGroup Group { get; set; }
        public DateTime UtcDate { get; set; }
    }
}
