namespace TaskDirectory1
{
    public interface IFileService
    {
        bool IsSuitable(byte[] s); 
        string GetInfo(byte[] d); 

    }
}