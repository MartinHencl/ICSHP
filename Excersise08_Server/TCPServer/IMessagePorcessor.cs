namespace TCPServer
{
    public interface IMessagePorcessor
    {
        void Process(string message);
    }
}