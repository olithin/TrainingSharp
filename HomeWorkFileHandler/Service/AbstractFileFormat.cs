namespace TaskDirectory1.Service
{
    public abstract class AbstractFileFormat : IFileService
    {
        public abstract bool IsSuitable(byte[] s);
        public abstract string GetInfo(byte[] s);
        public string HandleFile(byte[] bytes)
        {
            string info = null;
            if(IsSuitable(bytes))
            {
                info = GetInfo(bytes);
            }

            return info;
        }
    }
}