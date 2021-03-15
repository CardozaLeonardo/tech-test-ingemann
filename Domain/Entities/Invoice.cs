using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Invoice: BaseEntity
    {
        public DateTime Date { get; set; }
        public float Tax { get; set; }

        public float SubTotal { get; set; }
        
        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
