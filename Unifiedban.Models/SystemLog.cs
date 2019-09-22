using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Data
{
    [Table("System", Schema = "log")]
    public class SystemLog
    {
        public enum Levels
        {
            Debug,
            Info,
            Warn,
            Error,
            Fatal
        }

        public int SystemLogId { get; set; }
        public string LoggerName { get; set; }
        public string Function { get; set; }
        public string Message { get; set; }
        public Levels Level { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
    }
}
