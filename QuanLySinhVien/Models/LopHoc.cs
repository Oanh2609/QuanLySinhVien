using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Models
{
    public class LopHoc
    {
        [Key]
        [Required, MinLength(3)]
        public string MaLop { get; set; }
        [Required]
        public string TenLop { get; set; }
        [Required]
        public string GVCN { get; set; }

        public string MaKhoa { get; set; }
        [ForeignKey("MaKhoa")]
        public virtual Khoa Khoa { get; set; }
    }

}