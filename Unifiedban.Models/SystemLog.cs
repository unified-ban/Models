/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models
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

        public enum ErrorCodes
        {
            OK,
            Error
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
