namespace FileSystem
{
    public interface IFileSystemWrapper : IExists, IFileNameOperations, IFileDetails, IDirectoryContents, IFileOperations, IFileChecker
    {
        void RefreshDirectory(string path);
        void RefreshFile(string fileName);

        string GetTempPath();
        char DirectorySeparatorChar { get; }
        string TempPath { get; }
    }
}