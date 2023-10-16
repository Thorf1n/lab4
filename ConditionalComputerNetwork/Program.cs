namespace ConditionalComputerNetwork
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Server server = new Server { IPAddress = "192.168.1.1", Power = 1000, OS = "Linux", Name = "Web Server" };
            Workstation workstation1 = new Workstation { IPAddress = "192.168.1.2", Power = 500, OS = "Windows", User = "User 1" };
            Workstation workstation2 = new Workstation { IPAddress = "192.168.1.3", Power = 600, OS = "MacOS", User = "User 2" };
            Router router = new Router { IPAddress = "192.168.1.254", Power = 800, OS = "Linux", NetworkInterface = "eth0" };

            Network network = new Network();
            network.AddDevice(server);
            network.AddDevice(workstation1);
            network.AddDevice(workstation2);
            network.AddDevice(router);

            network.EstablishConnection(server, workstation1);
            network.TransferData(workstation1, server, "Data to transfer"); ;

        }
    }
}
