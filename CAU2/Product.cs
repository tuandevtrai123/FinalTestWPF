using System;
namespace CAU2
{
    public class Product
    {
        // KHAI BAO CAC THUOC TINH CUA CLASS PRODUCT
        private string name;
        private double price;
        private int number;

        // CONSTRUCTOR KHONG THAM SO
        public Product()
        {
            // Gan tuy y cho doi tuong duoc khoi tao
            Name = "abc";
            Price = 100;
            Number = 1;
        }

        // CONSTRUCTOR CO THAM SO
        public Product(string NameProduct, double PriceProduct, int NumberProduct)
        {
            // Gan cac gia tri cua tham so cho doi tuong duoc khoi tao
            Name = NameProduct;
            Price = PriceProduct;
            Number = NumberProduct;
        }

        // KHAI BAO CAC PROPERTIES
        public string Name { get; set; }
        public double Price { get; set; }
        public int Number { get; set; }

        // Khai bao public de truy xuat
        public void Input()
        {
            // Thuc hien gan gia tri cho product
            Console.WriteLine("Nhap vao ten san pham: ");
            Name = Console.ReadLine();

            Console.WriteLine("Nhap vao gia san pham: ");
            Price = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao so luong san pham: ");
            Number = int.Parse(Console.ReadLine());
        }

        // Khai bao public de truy xuat
        public double Pay()
        {
            // Khai bao bien tong tien
            double total = 0;
            // Tong tien se bang gia tri product nhan voi so luong 
            total = Number * Price;
            if(Number >= 4 && Number <=9)
            {
                // Neu mua tu 4->9 sp giam 5%
                return total * 0.95;
            }
            else if(Number > 9)
            {
                // Neu mua nhieu hon 9 sp giam 10%
                return total * 0.9;
            }
            else
            {
                // Neu mua nho hon 4 thi khong giam
                return total;
            }
        }   
    }
}
