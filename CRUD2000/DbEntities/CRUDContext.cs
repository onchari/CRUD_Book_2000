using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD2000.Models;

namespace CRUD2000.DbEntities
{
    public class CRUDContext : DbContext
    {
        public CRUDContext(DbContextOptions<CRUDContext> options) :base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new BookMap(modelBuilder.Entity<Book>());
        }
        public DbSet<CRUD2000.Models.BookViewModel> BookViewModel { get; set; }
    }
}
