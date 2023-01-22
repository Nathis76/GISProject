namespace GISProject.Models
{
    public class Point
    {
        public int Id { get; set; }
        public double longitude { get; set; }

        public double latitude { get; set; }

        public string? title { get; set; }

        public string? description { get; set; }

        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public List<Category>? Categories { get; set; }
    }
}
