using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Mappings
{
    public class InvoiceDetailMap: IEntityTypeConfiguration<InvoiceDetail>
    {
        public void Configure(EntityTypeBuilder<InvoiceDetail> builder)
        {
            builder.HasKey(d => new {d.ItemId, d.InvoiceId});
            builder.HasOne(d => d.Invoice)
                .WithMany(i => i.InvoiceDetails)
                .HasForeignKey(d => d.InvoiceId);

            builder.HasOne(d => d.Item)
                .WithMany(i => i.InvoiceDetails)
                .HasForeignKey(d => d.ItemId);
            
        }
    }
}