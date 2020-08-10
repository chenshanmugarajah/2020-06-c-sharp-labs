using System;
using System.Collections.Generic;

namespace lab_42_xml_deserialisation.Models
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
