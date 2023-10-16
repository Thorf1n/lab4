

namespace ConditionalComputerNetwork
{
    internal class Router : Computer, IConnectable
    {
    public string NetworkInterface { get; set; }

    public void Connect(Computer otherDevice)
    {
        Console.WriteLine($"Router connected {otherDevice.IPAddress} via {NetworkInterface}");
    }

    public void TransferData(string data)
    {
        Console.WriteLine($"Router transferred data: {data}");
    }
}

}

