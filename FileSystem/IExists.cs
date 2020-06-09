namespace FileSystem
{
    public interface IExists
    {
        bool Exists(string path);
        bool FileExists(string filePath);
        bool DirectoryExists(string directoryPath);
    }
}