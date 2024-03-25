﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ThuongMaiDienTuWebAPI.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Accounts = new HashSet<Account>();
            ProductArticles = new HashSet<ProductArticle>();
        }

        public int EmployeeId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string IdentityNo { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }
        public string EmployeeStatus { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<ProductArticle> ProductArticles { get; set; }
    }
}