namespace conCI
{
    public interface ILogger
    {
        void Write(string name);

        void WriteAsync(string name);
    }
}