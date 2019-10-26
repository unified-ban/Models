using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models.Translation
{
    [Table("Entry", Schema = "lang")]
    public class Entry
    {
        public string LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public string KeyId { get; set; }
        public virtual Key Key { get; set; }
        public string Translation { get; set; }
    }
}
