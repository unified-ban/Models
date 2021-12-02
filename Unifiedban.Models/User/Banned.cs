/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.User
{
    [Table("User_Banned", Schema = "dbo")]
    public class Banned
    {
        public enum BanReasons
        {
            Spam = 0,
            Scam = 1,
            Harassment = 2,
            Other = 4
        }

        [Key]
        public long TelegramUserId { get; set; }
        public BanReasons Reason { get; set; }
        public DateTime UtcDate { get; set; }
    }
}
