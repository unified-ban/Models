/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

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
        public int TelegramUserId { get; set; }
        public string Name { get; set; }
        public string ProfilePicture { get; set; }
        public DateTime LastActionUtc { get; set; }
    }
}
