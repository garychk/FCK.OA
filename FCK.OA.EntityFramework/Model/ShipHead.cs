﻿using FCK.OA.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FCK.OA.EntityFramework.Model
{
    [Table("ShipHead")]
    public class ShipHead : Entity<long>, ISoftDelete, IMustHaveCompany
    {
        [Required, MaxLength(8)]
        public string Company { get; set; }
        [Required, StringLength(50)]
        public string ProductNum { get; set; }
        public decimal ProductQty { get; set; }
        [Required, MaxLength(50)]
        public string ContractNum { get; set; }
        [Required]
        public long OrderNum { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        public DateTime PromiseDate { get; set; }
        [Required]
        public long CustID { get; set; }
        [Required]
        [StringLength(10)]
        public string ShipviaCode { get; set; }
        [StringLength(20)]
        public string EnterPerson { get; set; }
        public int EmpId { get; set; }
        [ForeignKey("EmpId")]
        public Employee Emp { get; set; }
        [DefaultValue(1)]
        public bool OpenOrder { get; set; }
        [MaxLength(2), DefaultValue("U")]
        public string ApproveStatus { get; set; }
        [DefaultValue(0)]
        public bool IsConfirm { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
        [StringLength(200)]
        public string RespDepartCodes { get; set; }
        [StringLength(20)]
        public string RevNum { get; set; }
        [Column(TypeName = "text")]
        public string Comment { get; set; }
        [StringLength(50)]
        public string ShipSize { get; set; }
        public decimal ShipWeight { get; set; }
    }
}
