namespace TrafficModellingSystem
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Road road = new Road { Length = 10, Width = 3, NumberOfLanes = 2, TrafficLevel = 3 };
            Vehicle car = new Vehicle { Speed = 60, Size = "Medium", Type = "Car" };

            TrafficSimulation simulation = new TrafficSimulation();
            simulation.SimulateMovement(car, road);
        }
    }
}
    
