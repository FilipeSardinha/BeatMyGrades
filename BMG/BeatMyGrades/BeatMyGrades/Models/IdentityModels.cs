using Microsoft.AspNet.Identity.EntityFramework;

namespace BeatMyGrades.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Email { get; set; }
        public bool ConfirmedEmail { get; set; }
        public bool Prof { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }
        public string School { get; set; }
        public string NIF { get; set; }
        public string Description { get; set; }
    }


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}