using System;

namespace WaterStateTransition
{
    public enum WaterState
    {
        Solid = 1,  
        Liquid = 2,  
        Gas = 3      
    }

    class Program
    {
        static void ShowWaterStateTransition(WaterState state = WaterState.Liquid)
        {
            switch (state)
            {
                case WaterState.Solid:
                    Console.WriteLine("Trạng thái nước: rắn (Đá).");
                    Console.WriteLine("Quá trình: Nước ở trạng thái rắn khi nhiệt độ dưới 0°C.");
                    break;
                case WaterState.Liquid:
                    Console.WriteLine("Trạng thái nước: lỏng.");
                    Console.WriteLine("Quá trình: Nước ở trạng thái lỏng giữa 0°C và 100°C.");
                    break;
                case WaterState.Gas:
                    Console.WriteLine("Trạng thái nước: Khí(hơi nước).");
                    Console.WriteLine("Quá trình: Nước chuyển thành hơi nước khi nhiệt độ trên 100°C.");
                    break;
                default:
                    Console.WriteLine("Trạng thái nước không hợp lệ.");
                    break;
            }
        }

        static void Main(string[] args)
        {
            ShowWaterStateTransition(WaterState.Solid);

            ShowWaterStateTransition(WaterState.Liquid);

            ShowWaterStateTransition(WaterState.Gas);

            Console.WriteLine("\nTrạng thái mặc định của nước:");
            ShowWaterStateTransition(); 
        }
    }
}
