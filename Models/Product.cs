﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ThuongMaiDienTuWebAPI.Models
{
    public partial class Product
    {
        public Product()
        {
            Carts = new HashSet<Cart>();
            OrderDetails = new HashSet<OrderDetail>();
            ProductArticles = new HashSet<ProductArticle>();
            ProductFeatures = new HashSet<ProductFeature>();
            ProductImages = new HashSet<ProductImage>();
        }

        public string ProductId { get; set; }
        public string Name { get; set; }
        public string IndoorDimension { get; set; }
        public double IndoorWeight { get; set; }
        public string OutdoorDimension { get; set; }
        public double OutdoorWeight { get; set; }
        public string HeatCapacity { get; set; }
        public string CoolingCapacity { get; set; }
        public int NumbersOfCooling { get; set; }
        public double PowerComsumption { get; set; }
        public string IndoorWarranty { get; set; }
        public string OutdoorWarranty { get; set; }
        public string RealeaseDate { get; set; }
        public decimal Price { get; set; }
        public string RadiatorMaterial { get; set; }
        public int BrandId { get; set; }
        public string ProductStatus { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductArticle> ProductArticles { get; set; }
        public virtual ICollection<ProductFeature> ProductFeatures { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}