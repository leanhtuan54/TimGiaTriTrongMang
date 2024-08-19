using System;
namespace Mang
{

    class Program
    {

        static void Main(string[] args)
        {
            // Bước 1: Khai báo mảng kiểu int với kích thước 5 phần tử
            int[] numbers = new int[5];

            // Bước 2: Thêm giá trị vào mảng bằng cách chèn vào các vị trí
            numbers[0] = 2;
            numbers[1] = 5;
            numbers[2] = 9;
            numbers[3] = 6;
            numbers[4] = 7;

            // Bước 3: In ra một vài giá trị của mảng
            Console.WriteLine("Gia tri cua phan tu 0: " + numbers[0]);
            Console.WriteLine("Gia tri cua phan tu 2: " + numbers[2]);
            Console.WriteLine("Gia tri cua phan tu 3: " + numbers[3]);

            // Bước 4: Tính tổng các phần tử của mảng
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }

            // In ra tổng các phần tử của mảng
            Console.WriteLine("Tong cac phan tu cua mang : " + total);

            // Giữ cửa sổ console mở để xem kết quả
            Console.ReadLine();
        
        }
    }
}