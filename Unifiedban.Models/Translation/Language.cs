/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.Translation
{
    [Table("Language", Schema = "lang")]
    public class Language
    {
        public enum State
        {
            NotRready = 0,
            Active = 1,
            Disabled = 2
        }
        public string LanguageId { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        [MaxLength(20)]
        [Required]
        public string UniversalCode { get; set; }
        [Required]
        public State Status { get; set; }
    }
}
