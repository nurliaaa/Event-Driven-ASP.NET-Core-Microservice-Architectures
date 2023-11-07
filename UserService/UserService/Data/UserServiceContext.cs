using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Data
{
    
        public class UserServiceContext : DbContext
        {
            public UserServiceContext(DbContextOptions<UserServiceContext> options)
                : base(options)
            {
            }

            public DbSet<UserService.Entities.User> User { get; set; }
        }

    
}
