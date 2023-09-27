using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhdiemTB
{
    internal class LyThuyet : Monhoc
    {
        float DiemTL;
        float DiemCK;
        public LyThuyet()
        {
            DiemCK = 0;
            DiemTL = 0;
        }
        public LyThuyet(float DiemTL, float DiemCK, string MaMon, string TenMon, int SoTC) : base(MaMon, TenMon, SoTC)
        {
            this.DiemTL = DiemTL;
            this.DiemCK = diemCK;
        }

        public override float TinhDTB()
        {
            return DiemTL*0.3f+DiemCK*0.7f;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap Diem tu luan:");
            DiemTL=float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Diem cuoi ki:");
            DiemCK=float.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("Ma mon\t\t Ten Mon\tsotc\tDiemTL\tDiemCK\tDiem Trung Binh\tDiem Chu");
            base.Xuat();
            Console.WriteLine("\t{0}\t{1}\t{2}\t\t\t{3}", DiemTL, DiemCK, TinhDTB(), DiemChu());
        }
    }
}