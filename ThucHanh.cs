using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhdiemTB
{
    internal class ThucHanh : Monhoc
    {
        float diem1;
        float diem2;
        float diem3;
        public ThucHanh()
        {
            diem1 = diem2 = diem3=0;
        }
        public ThucHanh(float diem1, float diem2, float diem3,string MaMon,string TenMon,int SoTc):base(MaMon,TenMon,SoTc)
        {
            this.diem1=diem1;
            this.diem2=diem2;
            this.diem3=diem3;
        }
        public override float TinhDTB()
        {
            return (diem1 + diem2+ diem3)/3;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap Diem 1 :");
            diem1=float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Diem 2 :");
            diem2=float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Diem 3 :");
            diem3=float.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("Ma mon\t\t Ten Mon\tsotc\tDiem1\tDiem2\tDiem3\tDiem Trung Binh\tDiem Chu");
            base.Xuat();
            Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t\t\t{4}", diem1, diem2,diem3, TinhDTB(), DiemChu());
        }
    }
}
