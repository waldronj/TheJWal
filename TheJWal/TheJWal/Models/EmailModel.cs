using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheJWal.Models
{
    public class EmailModel
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public string SenderEmail { get; set; }
        public string Message { get; set; }
    }
}