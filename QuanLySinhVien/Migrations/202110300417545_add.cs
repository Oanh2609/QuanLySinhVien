namespace QuanLySinhVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Khoas",
                c => new
                    {
                        MaKhoa = c.String(nullable: false, maxLength: 128),
                        TenKhoa = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaKhoa);
            
            CreateTable(
                "dbo.LopHocs",
                c => new
                    {
                        MaLop = c.String(nullable: false, maxLength: 128),
                        TenLop = c.String(nullable: false),
                        GVCN = c.String(nullable: false),
                        MaKhoa = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaLop)
                .ForeignKey("dbo.Khoas", t => t.MaKhoa)
                .Index(t => t.MaKhoa);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        MaSinhVien = c.String(nullable: false, maxLength: 128),
                        HoVaTen = c.String(nullable: false),
                        GioiTinh = c.String(nullable: false),
                        DiaChi = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        MaLop = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaSinhVien)
                .ForeignKey("dbo.LopHocs", t => t.MaLop)
                .Index(t => t.MaLop);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhViens", "MaLop", "dbo.LopHocs");
            DropForeignKey("dbo.LopHocs", "MaKhoa", "dbo.Khoas");
            DropIndex("dbo.SinhViens", new[] { "MaLop" });
            DropIndex("dbo.LopHocs", new[] { "MaKhoa" });
            DropTable("dbo.SinhViens");
            DropTable("dbo.LopHocs");
            DropTable("dbo.Khoas");
        }
    }
}
