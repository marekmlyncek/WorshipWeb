using System.ComponentModel.DataAnnotations;

namespace WorshipWebApp.Models
{
    public class Source
    {
        public int Id { get; set; }
        [MaxLength(255)]public string Name { get; set; }
    }
}