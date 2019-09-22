using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.Group
{
    [Table("Group_DashboardUser", Schema = "dbo")]
    public class DashboardUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string DashboardUserId { get; set; }
        public string Name { get; set; }
        public string ProfilePicture { get; set; }
        public DateTime LastActionUtc { get; set; }
    }
}
