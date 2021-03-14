using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Persistence.Mappings;

namespace Persistence.Context
{
    public class AppDbContext: DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> opt): base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new InvoiceDetailMap());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
