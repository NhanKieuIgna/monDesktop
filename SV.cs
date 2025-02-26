using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH1
{
    internal abstract class SV
    {
        protected string maSV;
        protected string hoTen;
        protected string namSinh;

        public SV(string maSV, string hoTen, string namSinh)
        {
            MaSV = maSV;
            this.HoTen = hoTen;
            this.NamSinh = namSinh;
        }

        public SV() { }
        public string MaSV { get => maSV; set => maSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NamSinh { get => namSinh; set => namSinh = value; }

        public abstract double tinhDiemTB();

        public override string ToString()
        {
            return maSV + ", " + hoTen + ", " + namSinh;
        }
    }
}
