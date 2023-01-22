namespace GISProject.Models
{
    public class AppUserDetails
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserID { get; set; }
        public ApplicationUser? User { get; set; }
    }
}
