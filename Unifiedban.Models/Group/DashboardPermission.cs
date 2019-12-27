/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

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
