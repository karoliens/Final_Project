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
        }
    }
}
