using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH1
{
    internal class SVCNTT : SV
    {
        private double diemPascal;
        private double diemCSharp;
        private double diemSQL;

        public SVCNTT(string maSV, string hoTen, string namSinh, double diemPascal, double diemCSharp, double diemSQL) : base(maSV, hoTen, namSinh)
        {
            DiemPascal = diemPascal;
            DiemCSharp = diemCSharp;
            DiemSQL = diemSQL;
        }

         

        public double DiemCSharp { get => diemCSharp; set => diemCSharp = value; }
        public double DiemPascal { get => diemPascal; set => diemPascal = value; }
        public double DiemSQL { get => diemSQL; set => diemSQL = value; }

        public override double tinhDiemTB()
        {
            return (diemCSharp + diemPascal + diemSQL) / 3;
        }

        public override string ToString()
        {
            return base.ToString() + ", Diem Pascal: " + diemPascal +  ", diem C#: " + diemCSharp + ", diem SQL: " + diemSQL + ", Trung binh: " + tinhDiemTB();
        }
    }
}
