

namespace ConditionalComputerNetwork
{
    internal class Server :Computer, IConnectable
    {
        public string Name { get; set; }

        public void Connect(Computer otherDevice)
        {
            Console.WriteLine($"{Name} connected to {otherDevice.IPAddress}");
        }

        public void TransferData(string data)
        {
            Console.WriteLine($"{Name} transferred data: {data}");
        }
    }

}
