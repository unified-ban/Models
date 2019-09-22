using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.User
{
    [Table("User_TempKicked", Schema = "dbo")]
    public class TempKicked
    {
        [Key]
        public int TelegramUserId { get; set; }
        [Key]
        public int TelegramChatId { get; set; }
        public DateTime UtcDate { get; set; }
    }
}
