using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ToDoAppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=HP\SQLEXPRESS;Database=ToDoApp;Trusted_Connection=true;TrustServerCertificate=true"); 
        }
        
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Doing> Doings { get; set; }
        public DbSet<Done> Dones { get; set; }
    }
}
