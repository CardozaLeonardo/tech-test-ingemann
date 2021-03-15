using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Application.Features.Invoices.Commands.SaveInvoice
{
    public class SaveInvoiceViewModel
    {
        [Required]
        public float SubTotal { get; set; }
        
        [Required]
        public ICollection<InvoiceDetailViewModel> InvoiceDetails { get; set; }
    }
}