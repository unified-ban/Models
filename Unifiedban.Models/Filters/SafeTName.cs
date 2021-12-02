/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.Filters
{
    [Table("Filter_SafeTName", Schema = "dbo")]
    public class SafeTName
    {
        [MaxLength(100)]
        public string Username { get; set; }
        public long TelegramChatId { get; set; }
        public DateTime RecordDate { get; set; } = DateTime.UtcNow;
    }
}
