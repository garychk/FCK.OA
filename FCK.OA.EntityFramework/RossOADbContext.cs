﻿using FCK.OA.EntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCK.OA.EntityFramework
{
    public partial class RossOADbContext : DbContext
    {
        public RossOADbContext()
            : base("name=RossOADbContext")
        {
        }
        public virtual IDbSet<Affairs> Affairs { get; set; }
        public virtual IDbSet<Depart> Depart { get; set; }
        public virtual IDbSet<Employee> Employee { get; set; }
        public virtual IDbSet<Part> Part { get; set; }
        public virtual IDbSet<ShipHead> ShipHead { get; set; }
        public virtual IDbSet<ShipDetail> ShipDetail { get; set; }
        public virtual IDbSet<Categories> Categories { get; set; }
        public virtual IDbSet<Company> Company { get; set; }
        public virtual IDbSet<Customer> Customer { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
