using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.Group
{
    [Table("Group_NightSchedule", Schema = "dbo")]
    public class NightSchedule
    {
        public enum Status
        {
            Deactivated = -1,
            Programmed = 0,
            Active = 1
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string NightScheduleId { get; set; }
        public string GroupId { get; set; }
        public virtual TelegramGroup Group { get; set; }
        public Status State { get; set; }
        public DateTime UtcStartDate { get; set; }
        public DateTime UtcEndDate { get; set; }
    }
}
