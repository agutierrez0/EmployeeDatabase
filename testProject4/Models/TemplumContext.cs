using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace testProject4.Models
{
    public partial class TemplumContext : DbContext
    {
       public TemplumContext(DbContextOptions<TemplumContext> options)
            : base(options)
        {

        }
        public DbSet<Employees> TemplumItems { get; set; }
    }
}