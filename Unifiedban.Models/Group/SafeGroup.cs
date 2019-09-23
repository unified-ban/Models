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
        public string GroupId { get; set; }
        public virtual TelegramGroup Group { get; set; }
        [Key]
        public string GroupName { get; set; }
    }
}
