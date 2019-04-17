namespace TCPServer
{
    public interface IMessageProcessor
    {
        void Process(string message);
    }
}