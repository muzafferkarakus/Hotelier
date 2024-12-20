﻿using Hotelier.EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;

namespace Hotelier.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=KARAKUS-NB; initial Catalog=HotelierDb; integrated Security=true");
        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
