using System;
using System.Collections.Generic;

namespace Salesforecast.Models
{
    public partial class Orderdetails
    {
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string ProductName { get; set; }
        public decimal Sales { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Profit { get; set; }
        public int Id { get; set; }

        public Orders Order { get; set; }
    }
}
