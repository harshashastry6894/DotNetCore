using System;
using System.Collections.Generic;

#nullable disable

namespace MyApp.Dtos.Rest
{
    public partial class CommandRest
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }
        public string Platform { get; set; }
    }
}
