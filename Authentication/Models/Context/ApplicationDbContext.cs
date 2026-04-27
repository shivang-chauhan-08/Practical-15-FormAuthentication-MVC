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
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<RoleMaster> RoleMasters { get; set; }
        public DbSet<UserRolesMapping> UserRolesMappings { get; set; }
    }
}