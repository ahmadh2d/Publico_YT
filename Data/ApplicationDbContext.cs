using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Publico_YT.Models;

namespace Publico_YT.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Message>()
                    .HasOne<AppUser>(a => a.Sender)
                    .WithMany(d => d.Messages)
                    .HasForeignKey(d => d.UserId);
        }

        public DbSet<Message> Messages { get; set; }
    }
}
