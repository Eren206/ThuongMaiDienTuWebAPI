﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ThuongMaiDienTuWebAPI.Models
{
    public partial class ProductFeature
    {
        public string ProductId { get; set; }
        public int FeatureId { get; set; }
        public string Description { get; set; }

        public virtual Feature Feature { get; set; }
        public virtual Product Product { get; set; }
    }
}