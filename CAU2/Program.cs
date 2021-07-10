using System;
using System.Collections.Generic;
using System.Linq;

namespace CAU2
{
    class Program
    {
        static void Main(string[] args)
        {
            // YEU CAU BAI TOAN
            // CAI DAT LOP PRODUCT DAU TIEN => XEM CLASS PRODUCT
            // Khai bao danh sach product

            Console.WriteLine("Nhap vao so luong san pham can mua: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>(n);

            // Duyet qua tung san pham cho nhap vao thong tin va tinh tong tien
            // Cach 1:
            double total = 0;
            for (int i = 0; i < n; i++)
            {
                // Khai bao 1 san pham
                Product p = new Product();
                // Nhap vao thong tin san pham
                p.Input();
                // Tinh tong tien
                total += p.Pay();

                // Them vao danh sach san pham
                products.Add(p);
            }

            Console.WriteLine("Tong tien phai tra la: "+total);
        }
    }
}
