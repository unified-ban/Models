/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.Filters
{
    [Table("Filter_BadWord", Schema = "dbo")]
    public class Image
    {
        public enum State
        {
            Disabled = 0,
            Experimental = 1,
            Active = 2
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ImageId { get; set; }
        public int? TelegramChatId { get; set; }
        [MaxLength(100)]
        public string ParentImageId { get; set; }
        public string HashData { get; set; }
        public RotateFlipType FlipType { get; set; }
        public State Status { get; set; }
        public DateTime UtcDate { get; set; }
        public int Match { get; set; }
    }
}
