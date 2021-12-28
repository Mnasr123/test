using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace online.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Item_details> Item_details { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Store> Store { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Description_N3> Description_N3 { get; set; }
        public DbSet<Description_N2> Description_N2 { get; set; }
        public DbSet<Description_N1> Description_N1 { get; set; }
        public DbSet<Company_Work> Company_Work { get; set; }
        public DbSet<Company_Type> Company_Type { get; set; }
        public DbSet<User> User { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}