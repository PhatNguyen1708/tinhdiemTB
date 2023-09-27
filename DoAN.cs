using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhdiemTB
{
    internal class DoAN:Monhoc
    {
        float diemGVHD;
        float diemGVPB;
        public DoAN()
        {
            diemGVHD = diemGVPB=0;
        }
        public DoAN(float diemGVHD, float diemGVPB,string MaMon,string TenMon,int SoTC):base(MaMon,TenMon,SoTC)
        {
            this.diemGVHD=diemGVHD;
            this.diemGVPB=diemGVPB;
        }
        public override float TinhDTB()
        {
            return (diemGVHD+diemGVPB)/2;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap Diem tu luan:");
            diemGVHD=float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Diem cuoi ki:");
            diemGVPB=float.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("Ma mon\t\t Ten Mon\tsotc\tDiemGVHD\tDiemGVPB\tDiem Trung Binh\tDiem Chu");
            base.Xuat();
            Console.WriteLine("\t{0}\t{1}\t{2}\t\t\t{3}", diemGVHD, diemGVPB, TinhDTB(), DiemChu());
        }
    }
}
