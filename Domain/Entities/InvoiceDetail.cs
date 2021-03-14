namespace Domain.Entities
{
    public class InvoiceDetail
    {
        public Invoice Invoice { get; set; }
        public Item Item { get; set; }
        public int InvoiceId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
    }
}