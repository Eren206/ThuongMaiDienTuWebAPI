﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ThuongMaiDienTuWebAPI.Models
{
    public partial class Status
    {
        public Status()
        {
            OrderStatuses = new HashSet<OrderStatus>();
        }

        public string StatusId { get; set; }
        public string Status1 { get; set; }
        public string Description { get; set; }

        public virtual ICollection<OrderStatus> OrderStatuses { get; set; }
    }
}