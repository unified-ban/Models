using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.Group
{
    [Table("Group_DefaultConfigParameter", Schema = "config")]
    public class ConfigurationParameter
    {
        [Key]
        public string ConfigurationParameterId { get; set; }
        public string Value { get; set; }
        public string Type { get; set; } // bool, string, int
        public string Values { get; set; } // possible values ; separated
    }
}
