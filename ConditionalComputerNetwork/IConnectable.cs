

namespace ConditionalComputerNetwork
{
    internal interface IConnectable
    {
        void Connect(Computer otherDevice);
        void TransferData(string data);
    }
}
