using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models
{
    [Table("ActionType", Schema = "dbo")]
    public class ActionType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ActionTypeId { get; set; }
        public string Name { get; set; }
    }
}
