namespace WorshipWebApp.Models
{
    public class Verse
    {
        public int Id { get; set; }
        public string Lyrics { get; set; }
        public VerseType VerseType { get; set; }
        public int Number { get; set; }
    }
}