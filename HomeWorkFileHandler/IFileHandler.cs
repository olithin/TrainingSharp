namespace TaskDirectory1
{
    public interface IFileHandler
    {
        bool IsSuitable(byte[] s); 
        string GetInfo(byte[] d); 

    }
}