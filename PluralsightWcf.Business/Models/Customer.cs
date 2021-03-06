﻿using System;
using System.Runtime.Serialization;

namespace PluralsightWcf.Business.Models
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string FullName { get; set; }

        [DataMember]
        public string Email { get; set; }
    }
}
