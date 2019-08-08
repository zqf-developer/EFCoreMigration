using EFCoreMigration.Data.Mapping.User;
using Microsoft.EntityFrameworkCore;
using System;

namespace EFCoreMigration.Data
{
    public class MyDataContext : DbContext
    {
        public MyDataContext(DbContextOptions<MyDataContext> options)
           : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
 
    }
}
