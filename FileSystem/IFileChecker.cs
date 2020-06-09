namespace FileSystem
{
    public interface IFileChecker
    {
        bool IsFileInUse(string filePath);
    }
}