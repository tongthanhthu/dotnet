using System;
using System.Collections;
using System.Collections.Generic;
namespace bai3
{
    class student
    {
        public int id { set; get; }
        public string name { set; get; }
        public int age { set; get; }
        public string address { set; get; }
        public double gpa { set; get; }
        
    }
    class mstudent
    {
        private List<student> students = null;
 
        public mstudent() {
            students = new List<student>();
        }
        public void add()
        {
            student st = new student();
            
            Console.WriteLine("Nhập mã sv ");
            st.id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập họ tên sv ");
            st.name = Console.ReadLine();

            Console.WriteLine("Nhập tuổi sv ");
            st.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập địa chỉ ");
            st.address =Console.ReadLine();

            Console.WriteLine("Nhập điểm GPA ");
            st.gpa =Convert.ToDouble(Console.ReadLine());

            students.Add(st);
            
        }
        public void Show(List<student> students)
        {
            if (students != null && students.Count > 0)
            {
                Console.WriteLine("{0, -5} {1, -10} {2, -5} {3, 5} {4, 5}",
                  "ID", "Name", "Address", "Age", "GPA");
                foreach (student st in students)
                {
                    Console.WriteLine("{0, -5} {1, -10} {2, -5} {3, 5} {4, 5}",
                              st.id, st.name, st.address, st.age, st.gpa);
                }
            }
            Console.WriteLine();
        }
        public List<student> getStudents()
        {
            return students;
        }

        public void Update(int id){
            student st = FindByID(id);
            if(st!=null)
            {
                Console.Write("Nhập tên sinh viên:");
                string name = Console.ReadLine();
                if(name != null && name.Length > 0)
                {
                    st.name = name;
                }
                
                Console.Write("Nhập địa chỉ");
                string address = Console.ReadLine();
                if(address != null && address.Length > 0)
                {
                    st.address = address;
                }
                Console.Write("Nhập tuổi");
                string age = Console.ReadLine();
                if(age != null && age.Length > 0)
                {
                    st.age =Convert.ToInt32(age);
                }

                Console.Write("Nhập điểm");
                string gpa = Console.ReadLine();
                if(gpa != null && gpa.Length > 0)
                {
                    st.gpa =Convert.ToDouble(gpa);
                }
            }else
            {
                Console.WriteLine("Sinh vien co ID = {0} khong ton tai.", id);
            }
        }

        public bool DeleteById(int id)
        {
            bool IsDeleted = false;
            student st = FindByID(id);
            if (st != null)
            {
                IsDeleted = students.Remove(st);
            }
            return IsDeleted;
        }
        public int SoLuongSinhVien()
        {
            int Count = 0;
            if (students != null)
            {
                Count = students.Count;
            }
            return Count;
        }
        public student FindByID(int id)
        {
            student searchResult = null;
            if (students != null && students.Count > 0)
            {
                foreach (student st in students)
                {
                    if (st.id == id)
                    {
                        searchResult = st;
                    }
                }
            }
            return searchResult;
        }
        public void SortByGPA()
        {
            students.Sort(delegate (student sv1, student sv2) {
                return sv1.gpa.CompareTo(sv2.gpa);
            });
        }
        public void SortByName()
        {
            students.Sort(delegate (student sv1, student sv2) {
                return sv1.name.CompareTo(sv2.name);
            });
        }
    }
}