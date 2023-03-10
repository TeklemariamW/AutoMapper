using System.ComponentModel.DataAnnotations;

namespace PizzaStore.Dtos
{
    public class CommandUpdateDto
    {
        [Required]
        public string? HowTo { get; set; }
        [Required]
        [MaxLength(5)]
        public string? Plateform { get; set; }
        [Required]
        public string? CommandLine { get; set; }
    }
}