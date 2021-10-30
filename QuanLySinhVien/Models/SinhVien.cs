using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Models
{
    
    public class SinhVien
    {
        [Key]
        [Required]
        public string MaSinhVien  { get; set; }
        [Required]
        public string HoVaTen  { get; set; }
        [Required]
        public string GioiTinh  { get; set; }
        [Required]
        public string DiaChi  { get; set; }
        [Required]
        public string Email  { get; set; }
     
        public string MaLop  { get; set; }
        [ForeignKey("MaLop")]
        public virtual LopHoc LopHoc { get; set; }

    }
}