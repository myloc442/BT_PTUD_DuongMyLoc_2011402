﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework_DB_First
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QlSinhVienContext : DbContext
    {
        public QlSinhVienContext()
            : base("name=QlSinhVienContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
    
        public virtual int usp_InsertSinhVien(string ten, Nullable<int> lop)
        {
            var tenParameter = ten != null ?
                new ObjectParameter("Ten", ten) :
                new ObjectParameter("Ten", typeof(string));
    
            var lopParameter = lop.HasValue ?
                new ObjectParameter("Lop", lop) :
                new ObjectParameter("Lop", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertSinhVien", tenParameter, lopParameter);
        }
    }
}
