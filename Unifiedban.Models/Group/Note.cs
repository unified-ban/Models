using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.Group
{
    [Table("Group_NightSchedule", Schema = "dbo")]
    public class Note
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NoteId { get; set; }
        public int TelegramChatId { get; set; }
        public string Tag { get; set; }
        public string Message { get; set; }
    }
}
