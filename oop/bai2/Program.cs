using System;
using System.Text.RegularExpressions;
namespace bai2
{
    class TestCandidate
    {
        static void Main(string[] args)
        {
            Candidate sv = new Candidate();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("nhập số sinh viên");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] m = new string[n];
            string[] ht = new string[n];
            string[] ns = new string[n];
            double[] t = new double[n];
            double[] v = new double[n];
            double[] a = new double[n];
            double[] tcm = new double[n];
            for(int i=0;i<n;i++){
                sv.nhapthongtin(i);
                m[i] = sv.ma;
                ht[i] = sv.hoten;
                ns[i] = sv.ngaythang;
                t[i] = sv.toan;
                v[i] = sv.van;
                a[i] = sv.anh;
                tcm[i] = sv.tongdiem();
            }
            double sum = 0;
            Console.WriteLine($"thông tin sinh viên có tổng điểm trên 1 là :");
            for(int j=0;j<n;j++){
                 sum = tcm[j];
                if(sum > 1){
                
                Console.Write($"sinh viên thứ {j+=1}");
                Console.Write($" mã sinh viên = ");
                Console.Write($" {m[j]} ");
                Console.Write($" tên sinh viên :");
                Console.Write(t[j]);
                }
            }

        }

    }

    class Candidate{
       public string ma { set; get; }
       public string hoten { set; get; }
       public string ngaythang { set; get; }
       public double van { set; get; }
       public double toan { set; get; }
       public double anh { set; get; }
       public void nhapthongtin(int i){
        Console.WriteLine($"nhập mã sv{i+=1} ");
        this.ma = Console.ReadLine();

        Console.WriteLine("nhập họ tên sv ");
        this.hoten = Console.ReadLine();

        Console.WriteLine("nhập ngày sinh sv ");
        this.ngaythang = Console.ReadLine();

        Console.WriteLine("nhập điểm văn ");
        this.van =Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("nhập điểm toán ");
        this.toan =Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("nhập điểm anh ");
        this.anh =Convert.ToDouble(Console.ReadLine());

    }
       public double tongdiem(){
          double tong = 0 ;
          tong = this.van + this.toan + this.anh;
           return tong;
       }

    }
}

