﻿using System.Runtime.Serialization;

namespace PluralsightWcf.Business.Models
{
    [DataContract]
    public class OrderItem
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int OrderId { get; set; }

        [DataMember]
        public int ProductId { get; set; }

        [DataMember]
        public int Quantity { get; set; }

        [DataMember]
        public decimal UnitPrice { get; set; }

        [DataMember]
        public decimal TotalPrice { get; set; }
    }
}
