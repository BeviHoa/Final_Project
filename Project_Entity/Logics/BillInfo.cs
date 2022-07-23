using System;
using System.Data;

namespace Project_Entity.Logics
{
    public class BillInfo
    {
        private int iD;
        private int maHoaDon;
        private int maSp;
        private DateTime Nngayban;
        private int soban;
        private int soLuong;
        private double donGia;
        private double thanhTien;

        public int ID { get => iD; set => iD = value; }
        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public int MaSp { get => maSp; set => maSp = value; }
        public DateTime Ngayban { get => Nngayban; set => Nngayban = value; }
        public int Soban { get => soban; set => soban = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }


        public BillInfo(int iD, int maHoaDon, int maSp, DateTime ngayban, int soban, int soLuong, double donGia, double thanhTien)
        {
            this.ID = iD;
            this.MaHoaDon = maHoaDon;
            this.MaSp = maSp;
            this.Ngayban = ngayban;
            this.Soban = soban;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.ThanhTien = thanhTien;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.MaHoaDon = (int)row["MaHoaDon"];
            this.MaSp = (int)row["MaSP"];
            this.Ngayban = (DateTime)row["ngayban"];
            this.Soban = (int)row["soban"];
            this.SoLuong = (int)row["SoLuong"];
            this.DonGia = (double)row["DonGia"];
            this.ThanhTien = (double)row["ThanhTien"];
        }

        public BillInfo()
        {
        }
    }
}
