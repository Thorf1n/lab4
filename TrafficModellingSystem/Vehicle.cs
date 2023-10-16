

namespace TrafficModellingSystem
{
    internal class Vehicle : IDriveable
    {
        public double Speed { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }

        public void Move()
        {
            Console.WriteLine($"Vehicle is moving at a speed of {Speed} km/h");
        }

        public void Stop()
        {
            Console.WriteLine("Vehicle has stopped");
        }
    }
}
