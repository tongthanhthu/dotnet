using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai1
{
    class Phanso
    {
        public int tuso { set; get; }
        public int mauso { set; get; }
 
        public void NhapPhanso()
        {
            Console.WriteLine("Tu so = ");
            this.tuso = int.Parse(Console.ReadLine());
            Console.WriteLine("mau so = ");
            do
                this.mauso = int.Parse(Console.ReadLine());
            while (this.mauso == 0);
        }
        public void InPhanso()
        {
            Console.Write("= " + tuso + "/" + mauso);
        }
        public Phanso tong(Phanso ph1, Phanso ph2)
        {
            Phanso ph3 = new Phanso();
            ph3.tuso = ph1.tuso * ph2.mauso + ph2.tuso * ph1.mauso;
            ph3.mauso = ph1.mauso * ph2.mauso;
            int uc = ucln(ph3.tuso, ph3.mauso);
            ph3.tuso = ph3.tuso / uc;
            ph3.mauso = ph3.mauso / uc;
            return ph3;
 
        }
        public Phanso tich(Phanso ph1, Phanso ph2){
            Phanso ph3 = new Phanso();
            ph3.tuso = ph1.tuso*ph2.tuso;
            ph3.mauso = ph1.mauso*ph2.mauso;
            int uc = ucln(ph3.tuso, ph3.mauso);
            ph3.tuso = ph3.tuso / uc;
            ph3.mauso = ph3.mauso / uc;
            return ph3;
        }
        public Phanso hieu(Phanso ph1, Phanso ph2){
            Phanso ph3 = new Phanso();
            ph3.tuso = ph1.tuso * ph2.mauso - ph2.tuso * ph1.mauso;
            ph3.mauso = ph1.mauso * ph2.mauso;
            int uc = ucln(ph3.tuso, ph3.mauso);
            ph3.tuso = ph3.tuso / uc;
            ph3.mauso = ph3.mauso / uc;
            return ph3;
        }
        public Phanso thuong(Phanso ph1,Phanso ph2){
            Phanso ph3 = new Phanso();
            ph3.tuso = ph1.tuso*ph2.mauso;
            ph3.mauso = ph1.mauso*ph2.tuso;
            int uc = ucln(ph3.tuso, ph3.mauso);
            ph3.tuso = ph3.tuso / uc;
            ph3.mauso = ph3.mauso / uc;
            return ph3;
        }
        public int ucln(int a, int b)
        {
            int r = 1;
            while (r != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

 
    }
    
}