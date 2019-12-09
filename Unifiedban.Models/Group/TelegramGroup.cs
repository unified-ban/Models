/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.Group
{
    [Table("Group_TelegramGroup", Schema = "dbo")]
    public class TelegramGroup
    {
        public enum Status
        {
            Banned = -1,
            Inactive = 0,
            Active = 1
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string GroupId { get; set; }
        public int TelegramChatId { get; set; }
        public string Title { get; set; }
        public Status State { get; set; }
        public string Configuration { get; set; }
        public string WelcomeText { get; set; }
        public string ChatLanguage { get; set; }
        public string SettingsLanguage { get; set; }
        public int ReportChatId { get; set;}
        public string RulesText { get; set; }

    }
}
