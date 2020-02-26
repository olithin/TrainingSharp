namespace TaskDirectory1.Strategies
{
    public interface IStrategy
    {
        bool IsSuitable(byte[] s);
        string GetInfo(byte[] d);
    }
}