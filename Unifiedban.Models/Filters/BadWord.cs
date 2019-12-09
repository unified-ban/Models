/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.Filters
{
    [Table("Filter_BadWord", Schema = "dbo")]
    public class BadWord
    {
        public enum State
        {
            Disabled = 0,
            Experimental = 1,
            Active = 2
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string BadWordId { get; set; }
        public int? TelegramChatId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string Regex { get; set; }
        public State Status { get; set; }
        public int Match { get; set; }
    }
}
