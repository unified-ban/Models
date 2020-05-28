/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models
{
    [Table("DashboardSession", Schema = "dbo")]
    public class DashboardSession
    {
        [MaxLength(100)]
        public string DashboardSessionId { get; set; }
        public DateTime StartDateUtc { get; set; }
        public int TelegramUserId { get; set; }
        public string TelegramFirstName { get; set; }
        public string TelegramLastName { get; set; }
        public string TelegramPhotoUrl { get; set; }
        public string TelegramUsername { get; set; }
        public string DeviceId { get; set; }
        [MaxLength(450)]
        public string DashboardUserId { get; set; }
        
        public virtual Group.DashboardUser DashboardUser { get; set; }
    }
}