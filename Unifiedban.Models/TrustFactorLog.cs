/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Unifiedban.Models.User;

namespace Unifiedban.Models
{
    [Table("TrustFactorLog", Schema = "log")]
    public class TrustFactorLog
    {
        public enum TrustFactorAction
        {
            limit,
            kick,
            ban,
            blacklist
        }

        [MaxLength(100)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string TrustFactorLogId { get; set; }
        [MaxLength(100)]
        public string TrustFactorId { get; set; }
        public virtual TrustFactor TrustFactor { get; set; }
        public TrustFactorAction Action { get; set; }
        public int ActionTakenBy { get; set; }
        public DateTime DateTime { get; set; }
    }
}
