namespace FileSystem
{
    public interface IFileOperations
    {
        void Copy(string source, string target, bool overwrite = false);
        void CopyDirectoryContents(string source, string target, bool overwrite = false);
        void CreateDirectory(string directory);
        void CreateFile(string filePath);

        void DeleteDirectory(string directory);
        void DeleteFile(string fileName);
    }
}