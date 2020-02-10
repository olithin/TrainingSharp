namespace TaskDirectory1.Service
{
    public interface IFileService
    {
        bool IsSuitable(byte[] s); 
        string GetInfo(byte[] d); 

    }
}