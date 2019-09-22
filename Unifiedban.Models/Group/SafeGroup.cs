using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.Group
{
    [Table("Group_SafeGroup", Schema = "dbo")]
    public class SafeGroup
    {
        [Key]
        public int TelegramChatId { get; set; }
        [Key]
        public string GroupName { get; set; }
    }
}
