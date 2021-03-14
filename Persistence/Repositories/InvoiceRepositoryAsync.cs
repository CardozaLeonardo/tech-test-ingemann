using Application.Interfaces.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class InvoiceRepositoryAsync: GenericRepositoryAsync<Invoice>, IInvoiceRepositoryAsync
    {
        private readonly DbSet<Invoice> _invoices;

        public InvoiceRepositoryAsync(AppDbContext dbContext) : base(dbContext)
        {
            _invoices = dbContext.Set<Invoice>();
        }
    }
}