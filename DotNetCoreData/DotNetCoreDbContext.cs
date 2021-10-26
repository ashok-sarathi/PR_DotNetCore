using DotNetCoreEntity.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreData
{
    public class DotNetCoreDbContext : DbContext
    {
        public DotNetCoreDbContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
