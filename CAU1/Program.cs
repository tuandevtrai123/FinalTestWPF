using System;
using System.Linq;

namespace CAU1
{
    class Program
    {
        static int[] a;
        static int n;

        static void Main(string[] args)
        {
            Console.WriteLine("Sua file ne !!!");
            Console.WriteLine("Test xem clone la gi !!!");
            INPUT();
            Console.WriteLine("Gia tri trung binh: "+MEAN());
            Console.WriteLine("So luong cac phan tu nho hon gia tri trung binh la : "+COUNT());
            Console.WriteLine("Phan tu lon nhat nhung nho hon gia tri trung binh la: "+LARGEST());
        }

        // Yeu cau a
        // Viet ham nhap day a
        static void INPUT()
        {
            // Ban dau mang a chua co do dai co dinh cung nhu cac phan tu ben trong

            // B1
            // Cho nguoi dung nhap vao do dai cua mang
            Console.WriteLine("Nhap vao n: ");
            n = int.Parse(Console.ReadLine());

            //B2
            // Gan do dai cua mang voi gia tri cua nguoi dung nhap vao
            a = new int[n];

            //B3
            // Nhan cac gia tri phan tu cua mang a
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap vao gia tri phan tu: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            // HOAN THANH VIEC NHAP GIA TRI CHO MANG A
        }

        // Yeu cau b
        // Viet ham tinh gia tri trung binh cua mang a
        // Gia tri trung binh = tong gia tri cac phan tu trong mang / do dai mang
        static double MEAN()
        {
            // Khai bao bien ket qua
            double result=0;
            for (int i = 0; i < n; i++)
            {
                // Tinh tong gia tri cac phan tu
                result += a[i];
            }
            // Tinh trung binh cua day
            result = result / a.Length;
            // Tra ve ket qua 
            return result;
        }

        // Yeu cau c
        // Viet ham dem cac so nho hon trung binh day a
        static int COUNT()
        {
            // Khai bao bien dem
            int count = 0;

            // Duyet qua tung phan tu trong day a
            // Neu phan tu nho hon trung binh day (MEAN) thi cong bien count them 1
            for (int i = 0; i < n; i++)
            {
                if(a[i]<MEAN())
                {
                    count++;
                }
            }
            return count;
        }

        // Yeu cau d
        // Tim gia tri lon nhat trong day a nhung nho hon trung binh day
        static int LARGEST()
        {
            // Sap xep mang a tang dan
            Array.Sort(a);

            // Duyet nguoc tu cuoi mang de so voi phan tu lon trong mang a
            for (int i = n-1; i >=0; i--)
            {
                // Neu thoa dieu kien thi tra ve phan tu do
                if(a[i]<MEAN())
                {
                    return a[i];
                }
            }
            // Neu khong phan tu nao thoa thi tra ve 0
            return 0;
        }
    }
}
