using System;

namespace String {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("nhập vào 1 chuỗi");
			string s = Console.ReadLine();
			char a = 'a';
			for (int i = 0; i < s.Length; i++) {
				if (s[i] == a) {
					Console.WriteLine($"vị trí {i}");
				}
			}
		}
    }
}