﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ThuongMaiDienTuWebAPI.Models
{
    public partial class Address
    {
        public Address()
        {
            Orders = new HashSet<Order>();
        }

        public int AddressId { get; set; }
        public string CityId { get; set; }
        public string DistrictId { get; set; }
        public string WardId { get; set; }
        public string DetailAddress { get; set; }
        public int IsDefault { get; set; }
        public string PhoneNumber { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}