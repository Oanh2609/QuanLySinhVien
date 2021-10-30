using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLySinhVien.Models
{
    public partial class DBConnext : DbContext
    {
        public DBConnext()
            : base("name=DBConnext")
        {
        }

        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
