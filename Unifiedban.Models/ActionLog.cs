/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

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
