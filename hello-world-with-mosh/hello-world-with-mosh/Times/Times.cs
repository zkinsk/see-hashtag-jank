

namespace hello_world_with_mosh.times
{
    public class Times
    {
        private readonly int hour;
        public Times(int hour = 10)
        {
            this.hour = hour;
        }

        public void ReportTime()
        {
            switch (hour)
            {
                case <= 10:
                    Console.WriteLine("It's Morning");
                    break;
                case < 14:
                    Console.WriteLine("It's Afternoon");
                    break;
                case < 18:
                    Console.WriteLine("It's Evening");
                    break;
                default:
                    Console.WriteLine("it's night");
                    break;


            }
        }
    }
}
