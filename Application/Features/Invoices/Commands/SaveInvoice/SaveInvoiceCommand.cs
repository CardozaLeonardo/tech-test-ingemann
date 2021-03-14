using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Invoices.Commands.SaveInvoice
{
    public class SaveInvoiceCommand: IRequest<Response<int>>
    {
        [Required]
        public ICollection<InvoiceDetailViewModel> InvoiceDetails { get; set; }
    }
}