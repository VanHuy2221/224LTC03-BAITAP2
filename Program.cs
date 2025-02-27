using System;

namespace EnumExample
{
    public enum DayOfWeek
    {
        Sunday = 1,
        Monday = 2,
        Tuesday = 3,
        Wednesday = 4,
        Thursday = 5,
        Friday = 6,
        Saturday = 7
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số từ 1 đến 7 để chọn ngày trong tuần:");
            int dayNumber = int.Parse(Console.ReadLine());

            if (dayNumber >= 1 && dayNumber <= 7)
            {
                string dayName = Enum.GetName(typeof(DayOfWeek), dayNumber);
                Console.WriteLine($"Ngày được nhập là: {dayName}");
            }
            else
            {
                Console.WriteLine("Số nhập vào không hợp lệ! Vui lòng nhập số từ 1 đến 7.");
            }
        }
    }
}
