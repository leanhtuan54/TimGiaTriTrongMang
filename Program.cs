using System;
namespace Mang
{

    class Program
    {

        static void Main(string[] args)
        {
            // Bước 1: Khai báo mảng chứa danh sách sinh viên
            string[] students = { "Dong", "Cong", "Duc", "Han", "Quang", "Connor", "Ha", "Anh", "Tuan", "Thu" };

            // Bước 2: Khai báo biến lưu tên tìm kiếm và gán với giá trị nhập vào
            Console.WriteLine("Dien ten sinh vien :");
            string inputName = Console.ReadLine();

            // Bước 3: Duyệt mảng sinh viên đã khai báo, tìm phần tử có giá trị bằng với tên đã nhập vào
            bool isExist = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Equals(inputName, StringComparison.OrdinalIgnoreCase)) // So sánh không phân biệt chữ hoa/thường
                {
                    Console.WriteLine("Vi tri cua " + inputName + " trong danh sach  la: " + (i + 1));
                    isExist = true;
                    break;
                }
            }

            // Nếu không tìm thấy tên trong danh sách
            if (!isExist)
            {
                Console.WriteLine("Khong tim thay " + inputName + " trong danh sach.");
            }

            // Giữ cửa sổ console mở để xem kết quả
            Console.ReadLine();
        
        }
    }
}