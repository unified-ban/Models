/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.User
{
    [Table("User_TrustFactor", Schema = "dbo")]
    public class TrustFactor
    {
        [MaxLength(100)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string TrustFactorId { get; set; }
        public long TelegramUserId { get; set; }
        public int Points { get; set; } = 100;
    }
}
