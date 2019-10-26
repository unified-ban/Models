using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models
{
    [Table("Action", Schema = "log")]
    public class ActionLog
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ActionLogId { get; set; }
        public string ActionTypeId { get; set; }
        public virtual ActionType ActionType { get; set; }
        public string GroupId { get; set; }
        public virtual Group.TelegramGroup Group { get; set; }
        public string Parameters { get; set; }
        public DateTime UtcDate { get; set; }
    }
}
