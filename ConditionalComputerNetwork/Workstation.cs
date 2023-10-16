using System;


namespace ConditionalComputerNetwork
{
    internal class Workstation : Computer, IConnectable
    {
        public string User { get; set; }

        public void Connect(Computer otherDevice)
        {
            Console.WriteLine($"User {User} connected to {otherDevice.IPAddress}");
        }

        public void TransferData(string data)
        {
            Console.WriteLine($"User {User} transferred data: {data}");
        }
    }
}