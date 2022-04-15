using System;
using Microsoft.EntityFrameworkCore;

namespace RestWithASPNet.Models.Context
{
    public class MySQLContext : DbContext
    {
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Book> Books { get; set; }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        
    }
}
