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
        public int TelegramUserId { get; set; }
        public Levels Level { get; set; }
    }
}
