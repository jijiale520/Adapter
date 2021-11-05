using Adapter.Properties;

namespace Adapter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //电能发动机驱动汽车
            Motor motor = new ElectricAdapter();
            motor.Drive();
            
            //光能发动机驱动汽车
            Motor motor2 = new OpticalAdapter();
            motor2.Drive();
        }
    }
}