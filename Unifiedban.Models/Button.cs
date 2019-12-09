/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models
{
    [Table("Button", Schema = "dbo")]
    public class Button
    {
        public enum Scopes
        {
            Welcome = 0,
            Note = 1
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ButtonId { get; set; }
        public int TelegramChatId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string Content { get; set; }
        public Scopes Scope { get; set; }
    }
}
