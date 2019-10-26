using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models
{
    [Table("SysConfig", Schema = "config")]
    public class SysConfig
    {
        [MaxLength(50)]
        public string SysConfigId { get; set; }
        public string Value { get; set; }
    }
}
