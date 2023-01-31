using Final_Project.Data.InitialData;
using Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Final_Project.Data
{
    public class RepairShopContext : DbContext
    {
        public RepairShopContext(DbContextOptions<RepairShopContext> options) : base(options)
        { 
        
        }

        public DbSet<Ticket> Tickets { get; set; }
        // public DbSet<User> Users { get; set; }
        // public DbSet<Ticket> Clients { get; set; }
        // public DbSet<RepairCategory> RepairCategories { get; set; }
        // public DbSet<Technician> Technicians { get; set; }
        // public DbSet<Device> Devices { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>().Property(x => x.TypeOfDevice)
                .HasConversion(v => v.ToString(), v => (ETypeOfDevice)Enum.Parse(typeof(ETypeOfDevice), v));

            modelBuilder.Entity<Ticket>().Property(x => x.TypeOfService)
                .HasConversion(v => v.ToString(), v => (ETypeOfService)Enum.Parse(typeof(ETypeOfService), v));

            modelBuilder.Entity<Ticket>().HasData(TicketInitialData.DataSeed);








            /*
       modelBuilder.Entity<Ticket>()
           .HasOne(d => d.Device)
           .WithOne(t => t.Ticket)
           .HasForeignKey<Device>(ti => ti.TicketId)
           .IsRequired(false);
       */








            /*
            modelBuilder.Entity<Ticket>()
                .HasData(
                new Ticket (1, "Reikia pakeisti iPhone 7 ekraną", DateTime.Now, 1, 1, 1, 2),
                new Ticket (2, "Reikia pakeisti iPhone X bateriją", DateTime.Now, 2, 2, 2, 3),
                new Ticket (3, "Reikia pakeisti SAMSUNG S20 ekraną", DateTime.Now, 3, 1, 2, 2),
                new Ticket (4, "Reikia perlituoti PS5 pultelio krovimo lizdą", DateTime.Now, 4, 3, 2, 4)
                );

            modelBuilder.Entity<Ticket>()
                .HasData(
                new Ticket (1, "Karolis", "karoliens@gmail.com", "+37061212121"),
                new Ticket (2, "Ieva", "ievuzis@gmail.com", "+37061252121"),
                new Ticket (3, "Tomas", "tomukas@gmail.com", "+37061212128"),
                new Ticket (4, "Saulius", "sauliens@gmail.com", "+37061215121")
                );

            modelBuilder.Entity<RepairCategory>()
               .HasData(
               new RepairCategory(1, "Data Recovery"),
               new RepairCategory(2, "Screen Replacement"),
               new RepairCategory(3, "Batery Replacement"),
               new RepairCategory(4, "Logic Board Repair")
               );

            modelBuilder.Entity<Technician>()
              .HasData(
              new Technician(1, "Karolis"),
              new Technician(2, "Artūras"),
              new Technician(3, "Armandas")
              );

            modelBuilder.Entity<Device>()
              .HasData(
              new Device(1, "iPhone 7", "Phone", 123456789111111),
              new Device(2, "iPhone X", "Phone", 123456789111118),
              new Device(3, "SAMSUNG S20", "Phone", 123456789111117),
              new Device(4, "PlayStation 5", "Gaming Console", 123456789111115)
              );
            */
        }
    }
}
