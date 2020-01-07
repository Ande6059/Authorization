using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Authorization.Models
{
    public class AuthorizationContext : DbContext
    {
        public AuthorizationContext (DbContextOptions<AuthorizationContext> options)
            : base(options)
        {
        }

        public DbSet<Authorization.Models.User> User { get; set; }
    }
}
