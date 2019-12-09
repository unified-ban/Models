/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models
{
    [Table("Operation", Schema = "log")]
    public class OperationLog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string OperationLogId { get; set; }
        public int TelegramChatId { get; set; }
        public int TelegramUserId { get; set; }
        [MaxLength(200)]
        public string Action { get; set; }
        [MaxLength(400)]
        public string Parameters { get; set; }
        public DateTime UtcDate { get; set; }
    }
}
