using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalComputerNetwork
{
    internal class Network
    
        {
        private List<IConnectable> devices = new List<IConnectable>();

        public void AddDevice(IConnectable device)
        {
            devices.Add(device);
        }

        public void EstablishConnection(IConnectable device1, IConnectable device2)
        {
            device1.Connect((Computer)device2);
            device2.Connect((Computer)device1);
        }

        public void TransferData(IConnectable sender, IConnectable receiver, string data)
        {
            sender.TransferData(data);
            receiver.TransferData(data);
        }
    }
}
