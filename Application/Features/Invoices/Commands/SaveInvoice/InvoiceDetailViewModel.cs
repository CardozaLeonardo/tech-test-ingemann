using System.ComponentModel.DataAnnotations;

namespace Application.Features.Invoices.Commands.SaveInvoice
{
    public class InvoiceDetailViewModel
    {
        [Required]
        public int Quantity { get; set; }
        
        [Required]
        public int ItemId { get; set; }
    }
}