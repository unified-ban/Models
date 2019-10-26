using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.Translation
{
    [Table("Key", Schema = "lang")]
    public class Key
    {
        public string KeyId { get; set; }
    }
}
