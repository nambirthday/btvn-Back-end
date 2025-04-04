//b1: Bài 1: Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào
//[tên], bạn[tuổi] tuổi!".

//using System;
//using System.Text;
//namespace LAB01
//{
//  class Program
//  {
//      static void Main(string[] args)
//      {
//          Console.Write("Nhap ten cua ban: ");
//          string ten = Console.ReadLine();

//          Console.Write("Nhap tuoi cua ban: ");
//          string tuoiInput = Console.ReadLine();
//          int tuoi = int.Parse(tuoiInput);  // Chuyển đổi chuỗi sang số nguyên

//          Console.WriteLine($"Xin chao {ten}, ban {tuoi} tuoi!");
//      }
//  }
//}

//b2: Bài 2: Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và
//chiều rộng.
//using System;
//using System.Text;
//namespace LAB01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Nhap chieu dai: ");
//            double chieuDai = double.Parse(Console.ReadLine());

//            Console.Write("nhap chieu rong: ");
//            double chieuRong = double.Parse(Console.ReadLine());

//            double dienTich = chieuDai * chieuRong;

//            Console.WriteLine($"Dien tich hinh chu nhat la: {dienTich}");
//        }
//    }

//}


//Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F
//Công thức: F = (C * 9 / 5) + 32

//using System;
//using System.Text;
//namespace LAB01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("nhap nhiet do (°C): ");
//            double doC = double.Parse(Console.ReadLine());

//            double doF = (doC * 9 / 5) + 32;

//            Console.WriteLine($"{doC}°C = {doF}°F");
//        }
//    }
//}

//Bài 4: Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn
//hay không.

//using System;
//using System.Text;
//namespace LAB01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("nhap 1 so nguyen: ");
//            int so = int.Parse(Console.ReadLine());

//            if (so % 2 == 0)
//            {
//                Console.WriteLine($"{so} la so chan.");
//            }
//            else
//            {
//                Console.WriteLine($"{so} la so le.");
//            }
//        }
//    }
//}


//Bài 5: Viết chương trình tính tổng và tích của hai số nhập từ bàn phím.
//using System;
//using System.Text;
//namespace LAB01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("nhap so thu nhat: ");
//            double so1 = double.Parse(Console.ReadLine());

//            Console.Write("nhap so thu hai: ");
//            double so2 = double.Parse(Console.ReadLine());

//            double tong = so1 + so2;
//            double tich = so1 * so2;

//            Console.WriteLine($"tong cua hai so: {tong}");
//            Console.WriteLine($"Tich cua hai so: {tich}");
//        }
//    }
//}


//Bài 6: Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số
//không.
//using System;
//using System.Text;
//namespace LAB01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//        Console.Write("Nhap 1 so: ");
//        double so = double.Parse(Console.ReadLine());

//            if (so > 0)
//            {
//                Console.WriteLine($"{so} la so duong.");
//            }
//            else if (so < 0)
//            {
//                Console.WriteLine($"{so} la so am.");
//            }
//            else
//            {
//            Console.WriteLine("So vua nhap la so 0.");
//            }
//        }
//    }
//}


//Bài 7: Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không.
//(Năm nhuận là năm chia hết cho 4, trừ các năm chia hết cho 100 nhưng không chia hết cho
//400).

//using System;
//using System.Net.NetworkInformation;
//using System.Text;
//namespace LAB01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Nhap mot nam: ");
//            int nam = int.Parse(Console.ReadLine());

//            if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
//            {
//                Console.WriteLine($"{nam} la nam nhuan.");
//            }
//            else
//            {
//                Console.WriteLine($"{nam} khong phai la nam nhuan.");
//            }
//        }
//    }

//}

//Bài 8: Viết chương trình in ra bảng cửu chương từ 1 đến 10.

//using System;
//using System.Text;
//namespace LAB01
//{
//    using System;

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine($"--- Bang cuu chuong {i} ---");

//                for (int j = 1; j <= 10; j++)
//                {
//                    Console.WriteLine($"{i} x {j} = {i * j}");
//                }

//                Console.WriteLine(); // dòng trống để cách nhau giữa các bảng
//            }
//        }
//    }

//}


//Bài 9: Viết chương trình tính giai thừa của một số nguyên dương n.

//using System;
//using System.Text;
//namespace LAB01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Nhap 1 so nguyen duong: ");
//            int n = int.Parse(Console.ReadLine());

//            if (n < 0)
//            {
//                Console.WriteLine("Vui long nhap 1 so nguyenn duong!");
//                return;
//            }

//            long giaiThua = 1;

//            for (int i = 1; i <= n; i++)
//            {
//                giaiThua *= i;
//            }

//            Console.WriteLine($"Giai thua cua {n} la: {giaiThua}");
//        }
//    }
//}


//Bài 10: Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không.

using System;
using System.Text;
namespace LAB01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap mot so nguyen: ");
            int so = int.Parse(Console.ReadLine());

            if (so <= 1)
            {
                Console.WriteLine($"{so} khong phai so nguyen to.");
                return;
            }

            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(so); i++)
            {
                if (so % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{so} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{so} khong phai so nguyen to.");
            }
        }
    }
}