/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.User
{
    [Table("User_Flood", Schema = "dbo")]
    public class Flood
    {
        [Key]
        public int TelegramUserId { get; set; }
        [Key]
        public int TelegramChatId { get; set; }
        public DateTime UtcDate { get; set; }
        [NotMapped]
        public int MessageCount { get; set; }

    }
}
