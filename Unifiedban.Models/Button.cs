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
        public string GroupId { get; set; }
        public virtual Group.TelegramGroup Group { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string Content { get; set; }
        public Scopes Scope { get; set; }
    }
}
