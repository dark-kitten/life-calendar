using Database.Models;
using Microsoft.EntityFrameworkCore;
 
namespace Database.LifeCalendar
{
    public class LifeCalendarContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventLabel> EventLabels { get; set; }
        public DbSet<Person> Persons { get; set; }

        public LifeCalendarContext(DbContextOptions<LifeCalendarContext> options)
            : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Account>()
                .HasOne(a => a.Person)
                .WithOne(p => p.Account)
                .HasForeignKey<Person>(p => p.AccountID);
        
            modelBuilder
                .Entity<Event>()
                .HasOne(e => e.Person)
                .WithMany(p => p.Events);

            modelBuilder
                .Entity<EventLabel>()
                .HasMany(el => el.Events)
                .WithOne(p => p.EventLabel);
        }

    }
}