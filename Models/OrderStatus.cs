﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ThuongMaiDienTuWebAPI.Models
{
    public partial class OrderStatus
    {
        public int OrdStatusId { get; set; }
        public int OrderId { get; set; }
        public DateTime DateUpdate { get; set; }
        public string StatusId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Status Status { get; set; }
    }
}