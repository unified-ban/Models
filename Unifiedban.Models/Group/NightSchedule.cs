/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

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
        public DateTime? UtcStartDate { get; set; } // start gate closure
        public DateTime? UtcEndDate { get; set; } // end gate closure
    }
}
