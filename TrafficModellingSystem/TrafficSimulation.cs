using System;


namespace TrafficModellingSystem
{
    internal class TrafficSimulation
    {
        public void SimulateMovement(Vehicle vehicle, Road road)
        {
            Console.WriteLine($"Vehicle is moving on a road of length {road.Length} km and width {road.Width} meters.");
            vehicle.Move();
            Console.WriteLine($"Traffic level on the road: {road.TrafficLevel}");
            vehicle.Stop();
        }
    }
}
