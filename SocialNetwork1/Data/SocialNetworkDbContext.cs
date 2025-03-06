using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialNetwork1.Entities;

namespace SocialNetwork1.Data
{
    public class SocialNetworkDbContext:IdentityDbContext<CustomIdentityUser,CustomIdentityRole,string>
    {
        public SocialNetworkDbContext(DbContextOptions<SocialNetworkDbContext> options)
            :base(options) { }
    }
}
