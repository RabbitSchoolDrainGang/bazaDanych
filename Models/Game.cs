namespace bazaDanych.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<String> Genre { get; set; } = new List<String>();
        public List<String> Platform { get; set; } = new List<String>();
        public string ReleaseDate { get; set; }
    }
}
