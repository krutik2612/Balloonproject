namespace Balloonproject.Models
{
    public class Balloon
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Material { get; set; } = "";
        public string Shape { get; set; } = "";
        public string Size { get; set; } = "";
        public string Color { get; set; } = "";
        public decimal Price { get; set; } 
        public string ImageUrl { get; set; } = "";
    }
}
