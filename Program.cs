//Bài 1: Viết một hàm để tính tổng của tất cả các số chẵn trong một mảng.

//using System;
//namespace LAB02
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Nhap so luong phan tu trong mang: ");
//            int n = int.Parse(Console.ReadLine());

//            int[] arr = new int[n];

//            // Nhập mảng từ bàn phím
//            Console.WriteLine("Nhap cac phan tu trong mang:");
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write($"Nhap phan tu thu {i + 1}: ");
//                arr[i] = int.Parse(Console.ReadLine());
//            }

//            // Gọi hàm tính tổng các số chẵn
//            int tongSoChan = TinhTongSoChan(arr);

//            // In kết quả
//            Console.WriteLine($"tong cac so chan trong mang la: {tongSoChan}");
//        }

//        // Hàm tính tổng các số chẵn trong mảng
//        static int TinhTongSoChan(int[] arr)
//        {
//            int tong = 0;
//            foreach (int so in arr)
//            {
//                if (so % 2 == 0) // Kiểm tra nếu số là chẵn
//                {
//                    tong += so;
//                }
//            }
//            return tong;
//        }
//    }
//}

//Bài 2: Viết chương trình nhập vào mảng gồm n phần tử nhập từ bàn phím. Viết hàm để kiểm
//tra xem một số có phải là số nguyên tố hay không, hiển thị chỉ số và giá trị của những phần tử
//là số nguyên tố trong mảng.

//using System;
//namespace LAB02
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("nhap so luong phan tu trong mang: ");
//            int n = int.Parse(Console.ReadLine());

//            int[] arr = new int[n];

//            // Nhập mảng từ bàn phím
//            Console.WriteLine("Nhap cac phan tu trong mang:");
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write($"Nhap phan tu thu {i + 1}: ");
//                arr[i] = int.Parse(Console.ReadLine());
//            }

//            // Kiểm tra các phần tử là số nguyên tố
//            Console.WriteLine("Cac phan tu la so nguyen to trong mang:");
//            for (int i = 0; i < n; i++)
//            {
//                if (IsPrime(arr[i]))
//                {
//                    Console.WriteLine($"Chi so {i} - Gia tri {arr[i]} la so nguyen to.");
//                }
//            }
//        }

//        // Hàm kiểm tra số nguyên tố
//        static bool IsPrime(int number)
//        {
//            if (number <= 1)
//                return false;
//            for (int i = 2; i <= Math.Sqrt(number); i++)
//            {
//                if (number % i == 0)
//                    return false;
//            }
//            return true;
//        }
//    }
//}

//Bài 3: Viết một hàm để đếm số lượng số âm và số dương trong một mảng gồm n phần tử nhập
//từ bàn phím.


//using System;
//namespace LAB02
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Nhap so luong phan tu trong mang: ");
//            int n = int.Parse(Console.ReadLine());

//            int[] arr = new int[n];

//            // Nhập mảng từ bàn phím
//            Console.WriteLine("Nhap cac phan tu trong mang:");
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write($"Phan tu thu {i + 1}: ");
//                arr[i] = int.Parse(Console.ReadLine());
//            }

//            // Gọi hàm để đếm số âm và số dương
//            int soAm, soDuong;
//            DemSoAmVaDuong(arr, out soAm, out soDuong);

//            // In kết quả
//            Console.WriteLine($"So luong am: {soAm}");
//            Console.WriteLine($"So luong duong: {soDuong}");
//        }

//        // Hàm đếm số âm và số dương
//        static void DemSoAmVaDuong(int[] arr, out int soAm, out int soDuong)
//        {
//            soAm = 0;
//            soDuong = 0;

//            foreach (int so in arr)
//            {
//                if (so < 0)
//                    soAm++;
//                else if (so > 0)
//                    soDuong++;
//            }
//        }
//    }
//}

//Bài 4: Viết hàm để tìm số lớn thứ hai trong một mảng các số nguyên.

//using System;
//namespace LAB02
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Nhap so luong phan tu trong mang: ");
//            int n = int.Parse(Console.ReadLine());

//            int[] arr = new int[n];

//            Console.WriteLine("Nhap cac phan tu:");
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write($"Phan tu thu {i + 1}: ");
//                arr[i] = int.Parse(Console.ReadLine());
//            }

//            // Gọi hàm tìm số lớn thứ hai
//            int? soLonThuHai = TimSoLonThuHai(arr);

//            if (soLonThuHai.HasValue)
//                Console.WriteLine($"So luong lon thu hai trong mang la: {soLonThuHai}");
//            else
//                Console.WriteLine("khong tim duoc so lon thu 2 trong mang (mang co it hon 2 gia tri khac nhau).");
//        }

//        // Hàm tìm số lớn thứ hai
//        static int? TimSoLonThuHai(int[] arr)
//        {
//            if (arr.Length < 2)
//                return null;

//            int max = int.MinValue;
//            int secondMax = int.MinValue;
//            bool foundSecond = false;

//            foreach (int num in arr)
//            {
//                if (num > max)
//                {
//                    secondMax = max;
//                    max = num;
//                    foundSecond = true;
//                }
//                else if (num < max && num > secondMax)
//                {
//                    secondMax = num;
//                    foundSecond = true;
//                }
//            }

//            return foundSecond ? (int?)secondMax : null;
//        }
//    }
//}


//Bài 5: Viết hàm hoán vị 2 số nguyên a và b nhập từ bàn phím.

//using System;
//namespace LAB02
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Nhập 2 số nguyên từ bàn phím
//            Console.Write("Nhap so nguyen a: ");
//            int a = int.Parse(Console.ReadLine());

//            Console.Write("Nhap so nguyen b: ");
//            int b = int.Parse(Console.ReadLine());

//            Console.WriteLine($"\nTruoc khi hoan vi: a = {a}, b = {b}");

//            // Gọi hàm hoán vị (sử dụng ref để truyền tham chiếu)
//            HoanVi(ref a, ref b);

//            Console.WriteLine($"Sau khi hoan vi: a = {a}, b = {b}");
//        }

//        // Hàm hoán vị 2 số nguyên
//        static void HoanVi(ref int x, ref int y)
//        {
//            int temp = x;
//            x = y;
//            y = temp;
//        }
//    }
//}



//Bài 6: Viết hàm sắp xếp mảng số thực n phần tử nhập từ bàn phím theo chiều tăng dần.

using System;
namespace LAB02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong phan tu trong mang: ");
            int n = int.Parse(Console.ReadLine());

            double[] arr = new double[n];

            // Nhập mảng từ bàn phím
            Console.WriteLine("Nhap cac phan tu (so thuc):");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phan tu thu {i + 1}: ");
                arr[i] = double.Parse(Console.ReadLine());
            }

            // Gọi hàm sắp xếp mảng
            SapXepTangDan(arr);

            // In mảng sau khi sắp xếp
            Console.WriteLine("\nMang sau khi sap xep tang dan:");
            foreach (double num in arr)
            {
                Console.Write($"{num} ");
            }
        }

        // Hàm sắp xếp mảng số thực theo chiều tăng dần (Bubble Sort)
        static void SapXepTangDan(double[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Hoán đổi
                        double temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}