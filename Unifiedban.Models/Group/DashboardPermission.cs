using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.Group
{
    [Table("Group_DashboardPermission", Schema = "dbo")]
    public class DashboardPermission
    {
        public enum Status
        {
            Banned = -1,
            Inactive = 0,
            Active = 1
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string DashboardPermissionId { get; set; }
        public string GroupId { get; set; }
        public virtual TelegramGroup Group { get; set; }
        public string  DashboardUserId { get; set; }
        public virtual DashboardUser DashboardUser { get; set; }
        public Status State { get; set; }
        public DateTime LastUpdateUtc { get; set; }
    }
}
