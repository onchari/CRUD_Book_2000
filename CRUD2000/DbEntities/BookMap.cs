using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD2000.DbEntities
{
    public class BookMap
    {
        public BookMap(EntityTypeBuilder<Book> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Name).IsRequired();
            entityTypeBuilder.Property(t => t.ISBN).IsRequired();
            entityTypeBuilder.Property(t => t.Author).IsRequired();
            entityTypeBuilder.Property(t => t.Publisher).IsRequired();
        }
    }
}
