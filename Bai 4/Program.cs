using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nChọn bài tập cần thực hiện (1-10) hoặc 0 để thoát:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Bai1();
                        break;
                    case 2:
                        Bai2();
                        break;
                    case 3:
                        Bai3();
                        break;
                    case 5:
                        Bai5();
                        break;
                    case 6:
                        Bai6();
                        break;
                    case 7:
                        Bai7();
                        break;
                    case 8:
                        Bai8();
                        break;
                    case 9:
                        Bai9();
                        break;
                    case 10:
                        Bai10();
                        break;
                    case 0:
                        exit = true;
                        Console.WriteLine("Thoát chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            }
        }
    
        // Bài 1: Kiểm tra số có chia hết cho 3 hay không
        static void Bai1()
        {
            Console.Write("Nhập vào một số nguyên: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 3 == 0)
            {
                Console.WriteLine("Số {0} chia hết cho 3.", number);
            }
            else
            {
                Console.WriteLine("Số {0} không chia hết cho 3.", number);
            }
        }

        // Bài 2: In bảng cửu chương từ 1 đến 10
        static void Bai2()
        {
            Console.Write("Nhập vào một số nguyên n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
        }

        // Bài 3: Kiểm tra số chính phương
        static void Bai3()
        {
            Console.Write("Nhập vào một số nguyên n: ");
            int n = int.Parse(Console.ReadLine());
            int scp = (int)Math.Sqrt(n);

            if (scp * scp == n)
            {
                Console.WriteLine($"Số {n} là số chính phương");
            }
            else
            {
                Console.WriteLine($"Số {n} không phải là số chính phương");
            }
        }

        // Bài 5: Tính số ngày trong tháng
        static void Bai5()
        {
            Console.Write("Nhập vào tháng (1-12): ");
            int month = int.Parse(Console.ReadLine());
            int days = 0;

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                days = 31;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                days = 30;
            }
            else if (month == 2)
            {
                Console.Write("Nhập vào năm: ");
                int year = int.Parse(Console.ReadLine());
                bool isLeapYear = (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));

                days = isLeapYear ? 29 : 28;
            }
            else
            {
                Console.WriteLine("Tháng không hợp lệ.");
                return;
            }

            Console.WriteLine($"Tháng {month} có {days} ngày.");
        }

        // Bài 6: Tính tổng các lũy thừa từ 1 đến n
        static void Bai6()
        {
            Console.Write("Nhập vào số nguyên n: ");
            int n = int.Parse(Console.ReadLine());
            long tong = 0;

            for (int i = 1; i <= n; i++)
            {
                long ketqua = 1;
                for (int j = 1; j <= i; j++)
                {
                    ketqua *= i;
                }
                tong += ketqua;
            }

            Console.WriteLine($"Tổng = {tong}");
        }

        // Bài 7: Tính tổng các số lẻ từ 1 đến n
        static void Bai7()
        {
            Console.Write("Nhập vào số nguyên n: ");
            int n = int.Parse(Console.ReadLine());
            int tong = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    tong += i;
                }
            }

            Console.WriteLine("Tổng của số lẻ là: " + tong);
        }

        // Bài 8: Liệt kê các số nguyên tố từ 1 đến n
        static void Bai8()
        {
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Các số nguyên tố từ 1 đến {n} là:");

            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        // Bài 9: Vẽ các tam giác
        static void Bai9()
        {
            Console.Write("Nhập số hàng: ");
            int n = int.Parse(Console.ReadLine());

            // Tam giác thông thường
            Console.WriteLine("\nTam giác thông thường:");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Tam giác ngược
            Console.WriteLine("\nTam giác ngược:");
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Tam giác đều
            Console.WriteLine("\nTam giác đều:");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // Bài 10: In dãy Fibonacci
        static void Bai10()
        {
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dãy Fibonacci với {n} phần tử là:");

            int a = 0, b = 1;

            if (n >= 1)
            {
                Console.Write(a + " ");
            }
            if (n >= 2)
            {
                Console.Write(b + " ");
            }

            for (int i = 3; i <= n; i++)
            {
                int fibo = a + b;
                Console.Write(fibo + " ");
                a = b;
                b = fibo;
            }
            Console.WriteLine();
            
        }
    }
}

