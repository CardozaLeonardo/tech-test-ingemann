using System.Collections.Generic;
using Domain.Common;

namespace Domain.Entities
{
    public class Item: BaseEntity
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public float Cost { get; set; }
        public bool Active { get; set; }
        
        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}