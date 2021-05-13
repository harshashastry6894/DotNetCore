using System.ComponentModel.DataAnnotations;

namespace MyApp.Dtos.Params
{
    public class CommandParams
    {
        [Required]
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }
        public string CodeFirst { get; set; }
    }
}