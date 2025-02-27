using System;

namespace ArrayAndForeachExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subjects = { "Toán", "Lý", "Hóa", "Anh Văn", "Sinh học" };

            int[] scores = { 85, 92, 78, 90, 88 };

            int total = 0;

            Console.WriteLine("Danh sách môn học và điểm:");
            int index = 0;
            foreach (int score in scores)
            {
                Console.WriteLine($"{subjects[index]}: {score} điểm");
                total += score;  
                index++;
            }

            double average = total / (double)scores.Length;

            Console.WriteLine("\nTổng điểm là: " + total);
            Console.WriteLine("Điểm trung bình là: " + average);
        }
    }
}
