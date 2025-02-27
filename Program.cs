using System;

class Program
{
    static void ChaoHoi(string ten = "bạn")
    {
        Console.WriteLine($"Xin chào, {ten}!");
    }

    static void Main()
    {
        Console.Write("Nhập tên của bạn (mặc định: bạn ): ");
        string ten = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(ten))
        {
            ChaoHoi();
        }
        else
        {
            ChaoHoi(ten);
        }
    }
}
