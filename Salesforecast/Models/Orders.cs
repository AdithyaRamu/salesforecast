using System;
using System.Collections.Generic;

namespace Salesforecast.Models
{
    public partial class Orders
    {
        public Orders()
        {
            Orderdetails = new HashSet<Orderdetails>();
        }

        public string OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
        public string ShipMode { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Segment { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? PostalCode { get; set; }
        public string Region { get; set; }

        public ICollection<Orderdetails> Orderdetails { get; set; }
    }
}
