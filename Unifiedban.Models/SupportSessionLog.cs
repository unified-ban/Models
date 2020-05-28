/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models
{
    [Table("SupportSession", Schema = "log")]
    public class SupportSessionLog
    {
        public enum SenderType
        {
            User = 0,
            Admin =1,
            Operator =2
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string LogId { get; set; }
        public string GroupId { get; set; }
        public virtual Group.TelegramGroup Group { get; set; }
        public int SenderId { get; set; }
        public string Text { get; set; }
        public DateTime Timestamp { get; set; }
        public SenderType Type { get; set; }
    }
}
