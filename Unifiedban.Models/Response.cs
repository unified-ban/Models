/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System.ComponentModel.DataAnnotations.Schema;

namespace Unifiedban.Models
{
    [NotMapped]
    public class Response
    {
        public int StatusCode { get; set; }
        public string StatusDescription { get; set; }
        public object Payload { get; set; }
    }
}