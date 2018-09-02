using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using POSSystem.Model;


namespace POSSystem
{
    class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\v11.0;Database=POSSystemDatabase;Trusted_Connection=True;");
        }
    }

    

}

