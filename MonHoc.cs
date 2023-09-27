using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhdiemTB
{
    abstract class Monhoc
    {
        protected string MaMon;
        protected string TenMon;
        protected int SoTC;
        public Monhoc()
        {
            MaMon = TenMon = string.Empty;
            SoTC = 0;
        }
        public Monhoc(string MaMon, string TenMon, int SoTC)
        {
            this.MaMon=MaMon;
            this.TenMon=TenMon;
            this.SoTC=SoTC;
        }
        public abstract float TinhDTB();
        public string DiemChu()
        {
            double dtb = TinhDTB();
            if (dtb <4)
                return "F";
            else
                if (dtb <=4.9)
                return "D";
            else
                if (dtb <=5.4)
                return "D+";
            else
                if (dtb <=6.4)
                return "C";
            else
                if (dtb <=6.9)
                return "C+";
            else
                if (dtb <=7.9)
                return "B";
            else
                if (dtb <=8.4)
                return "B+";
            else
                return "A";
        }
        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ma mon hoc:");
            MaMon=Console.ReadLine();
            Console.WriteLine("Nhap ten mon hoc:");
            TenMon=Console.ReadLine();
            Console.WriteLine("Nhap so tinh chi mon hoc:");
            SoTC=int.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.Write("{0}\t\t{1}\t{2}", MaMon, TenMon, SoTC);
        }
    }
}
