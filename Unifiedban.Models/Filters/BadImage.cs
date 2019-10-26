using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.Filters
{
    [Table("Filter_BadImage", Schema = "dbo")]
    public class BadImage
    {
        public enum State
        {
            Disabled = 0,
            Experimental = 1,
            Active = 2
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string BadImageId { get; set; }
        public string GroupId { get; set; }
        public virtual Group.TelegramGroup Group { get; set; }
        [MaxLength(100)]
        public string ParentImageId { get; set; }
        public string HashData { get; set; }
        public RotateFlipType FlipType { get; set; }
        public State Status { get; set; }
        public DateTime UtcDate { get; set; }
        public int Match { get; set; }
    }
}
