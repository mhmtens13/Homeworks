using System;
using System.Collections.Generic;

namespace IO___CodeFirst_EntFram.Models
{
    public partial class Order_Subtotal
    {
        public int OrderID { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
    }
}
