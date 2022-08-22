using System;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
namespace bai2
{
    class TestCandidate
    {
        static void Main(string[] args)
        {
            xuly sv = new xuly();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("nhập số sinh viên");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++){
                sv.nhapthongtin(i);

            }
            Console.WriteLine($"danh sách sinh viên có tổng điểm trên 1 :");
            sv.tongdiem(sv.getStudent());

        }

    }

    class Candidate{
       public string ma { set; get; }
       public string hoten { set; get; }
       public string ngaythang { set; get; }
       public double van { set; get; }
       public double toan { set; get; }
       public double anh { set; get; }
    }
    class xuly{
        private List<Candidate> student = null;
 
        public xuly() {
            student = new List<Candidate>();
        }
       public void nhapthongtin(int i){
        Candidate sv = new Candidate();
        Console.WriteLine($"nhập mã sv{i+=1} ");
        sv.ma = Console.ReadLine();

        Console.WriteLine("nhập họ tên sv ");
        sv.hoten = Console.ReadLine();

        Console.WriteLine("nhập ngày sinh sv ");
        sv.ngaythang = Console.ReadLine();

        Console.WriteLine("nhập điểm văn ");
        sv.van =Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("nhập điểm toán ");
        sv.toan =Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("nhập điểm anh ");
        sv.anh =Convert.ToDouble(Console.ReadLine());
        student.Add(sv);

    }
        public void tongdiem(List<Candidate> student){
            double tong = 0;
            Console.WriteLine("{0, -5} {1, -10} {2, -5}",
                  "ma", "Name", "ngaythang");
            foreach (Candidate sv in student)
            {
               tong = sv.van + sv.anh + sv.toan;
               if(tong>0){
                Console.WriteLine("{0, -5} {1, -10} {2, -5}",
                sv.ma, sv.hoten, sv.ngaythang);
               }
               else{
                Console.WriteLine("không có thí sinh nào tổng điểm trên 1");

               }
            }

       }
      public List<Candidate> getStudent()
        {
            return student;
        }

    }
 }


