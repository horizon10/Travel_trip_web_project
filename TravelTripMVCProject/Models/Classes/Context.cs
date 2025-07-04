﻿using System.Data.Entity;

namespace TravelTripMVCProject.Models.Classes
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AddressBlog> AdressBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<AboutMe> AboutMes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Oneri> Oneris { get; set; }
    }
}
