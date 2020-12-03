using System;
using System.Collections.Generic;

#nullable disable

namespace MyApp.Models
{
    public partial class Command
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }
        public string Platform { get; set; }
        public string CodeFirst { get; set; }
    }
}
