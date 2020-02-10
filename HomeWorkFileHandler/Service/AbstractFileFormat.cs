namespace TaskDirectory1.Service
{
    public abstract class AbstractFileFormat : IFileService
    {
        public abstract bool IsSuitable(byte[] s);
        public abstract string GetInfo(byte[] s);
        public void HandleFile(byte[] bytes)
        {
            if(IsSuitable(bytes))
            {
                GetInfo(bytes);
            }
        }
    }
}