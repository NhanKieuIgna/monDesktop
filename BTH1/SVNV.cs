using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH1
{
    internal class SVNV : SV
    {
        private double diemVHCoDien;
        private double diemVHHienDai;

        public SVNV(string maSV, string hoTen, string namSinh, double diemVHCoDien, double diemVHHienDai) : base(maSV, hoTen, namSinh)
        {
            this.diemVHCoDien = diemVHCoDien;   
            this.diemVHHienDai = diemVHHienDai;
        }

        public SVNV() { }

        public double DiemVHCoDien { get => diemVHCoDien; set => diemVHCoDien = value; }
        public double DiemVHHienDai { get => diemVHHienDai; set => diemVHHienDai = value; }

        public override double tinhDiemTB()
        {
            return (diemVHCoDien + diemVHHienDai) / 2;
        }

        public override string ToString()
        {
            return base.ToString() + ", Diem Van hoc co dien: " + diemVHCoDien + ", diem Van hoc hien dai " + diemVHHienDai + ", Trung binh: " + tinhDiemTB();
        }
    }
}
