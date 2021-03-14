using Application.Features.Invoices.Commands.SaveInvoice;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping
{
    public class InvoiceProfile: Profile
    {
        public InvoiceProfile()
        {
            CreateMap<SaveInvoiceViewModel, Invoice>();
            CreateMap<InvoiceDetailViewModel, InvoiceDetail>();
        }
    }
}