using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorshipWebApp.Models
{
    public class Song
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public                  int    IdNumber { get; set; }
        [MaxLength(255)] public string Name     { get; set; }
        [MaxLength(255)] public string Artist   { get; set; }
        [MaxLength(255)] public string Album    { get; set; }
        public Source Source   { get; set; }
        public ICollection<Verse> Verses { get; set; }
        [MaxLength(255)] public string LyricsMapper { get; set; }
    }
}