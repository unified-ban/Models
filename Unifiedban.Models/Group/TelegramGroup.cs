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
        public long TelegramChatId { get; set; }
        public string Title { get; set; }
        public Status State { get; set; }
        public string Configuration { get; set; }
        public string WelcomeText { get; set; }
        public string ChatLanguage { get; set; }
        public string SettingsLanguage { get; set; }
        public long ReportChatId { get; set;}
        public string RulesText { get; set; }
    }
}
