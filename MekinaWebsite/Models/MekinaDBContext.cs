using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MekinaWebsite.Models
{
    public class MekinaDBContext : IdentityDbContext
    {
        public MekinaDBContext(DbContextOptions<MekinaDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CarsList> carLists { get; set; }
        public virtual DbSet<BookingModel> bookingList { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
