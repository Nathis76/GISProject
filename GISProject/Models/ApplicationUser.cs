using Microsoft.AspNetCore.Identity;
using System.Drawing;

namespace GISProject.Models
{
    public class ApplicationUser :IdentityUser
    {
        public List<Point>? Points { get; set; }

        public AppUserDetails? Detail { get; set; }

    }
}
