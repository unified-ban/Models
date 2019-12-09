/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models
{
    [Table("Operator", Schema = "dbo")]
    public class Operator
    {
        public enum Levels
        {
            Basic = 0,
            Advanced = 1,
            Super = 2
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string OperatorId { get; set; }
        public string TelegramUserId { get; set; }
        public Levels Level { get; set; }
    }
}
