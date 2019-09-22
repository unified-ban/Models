using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.User
{
    [Table("User_Banned", Schema = "dbo")]
    public class Banned
    {
        public enum BanReasons
        {
            Spam = 0,
            Scam = 1,
            Harassment = 2,
            Other = 4
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BannerUserId { get; set; }
        public int TelegramUserId { get; set; }
        public int TelegramChatId { get; set; }
        public BanReasons Reason { get; set; }
        public DateTime UtcDate { get; set; }
    }
}
