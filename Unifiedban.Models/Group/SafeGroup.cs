/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.Group
{
    [Table("Group_SafeGroup", Schema = "dbo")]
    public class SafeGroup
    {
        public string GroupId { get; set; }
        public virtual TelegramGroup Group { get; set; }
        public string GroupName { get; set; }
    }
}
