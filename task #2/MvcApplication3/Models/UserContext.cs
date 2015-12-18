using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcApplication3.Models
{
    public class UserContext : DbContext
    {
       // public HttpPostedFileBase File { get; set; }
        public DbSet<User> Users { get; set; }
    }
}