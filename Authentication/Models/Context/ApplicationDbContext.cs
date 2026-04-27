using Authentication.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Authentication.Models.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        : base("name=connString")
        {
        }
        public DbSet<User> Users { get; set; }
    }
}