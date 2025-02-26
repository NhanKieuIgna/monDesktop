using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH1
{
    internal class SVVL : SV
    {
        private double diemCoHoc;
        private double diemDienHoc;
        private double diemQuangHoc;
        private double diemVatLiHatNhan;

        public double DiemCoHoc { get => diemCoHoc; set => diemCoHoc = value; }
        public double DiemDienHoc { get => diemDienHoc; set => diemDienHoc = value; }
        public double DiemQuangHoc { get => diemQuangHoc; set => diemQuangHoc = value; }
        public double DiemVatLiHatNhan { get => diemVatLiHatNhan; set => diemVatLiHatNhan = value; }

        public SVVL(string maSV, string hoTen, string namSinh ,double diemCoHoc, double diemDienHoc, double diemQuangHoc, double diemVatLiHatNhan) : base(maSV, hoTen, namSinh)
        {
            this.DiemCoHoc = diemCoHoc;
            this.DiemDienHoc = diemDienHoc;
            this.DiemQuangHoc = diemQuangHoc;
            this.DiemVatLiHatNhan = diemVatLiHatNhan;
        }

        public SVVL() { }
        public override double tinhDiemTB()
        {
            return (DiemCoHoc + DiemDienHoc + DiemQuangHoc + DiemVatLiHatNhan) /4;
        }

        public override string ToString()
        {
            return base.ToString() + ", Diem Co Hoc: " + diemCoHoc + ", diem Dien Hoc " + diemDienHoc + ", diem Quang Hoc: " + diemQuangHoc + ", diem Vat Li Hat Nhan: " + diemVatLiHatNhan + ", Trung binh: " + tinhDiemTB();
        }
    }
}
