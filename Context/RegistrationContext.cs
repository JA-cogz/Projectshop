using SmartShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace SmartShop.Context
{
    public class RegistrationContext : DbContext
    {
        public RegistrationContext() : base("Context")
        {

        }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
    }
}