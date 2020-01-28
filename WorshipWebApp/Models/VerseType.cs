using System.ComponentModel.DataAnnotations;

namespace WorshipWebApp.Models
{
    public class VerseType
    {
        public int Id { get; set; }
        [MaxLength(255)]public string Type { get; set; }
    }
}