namespace FileSystem
{
    public interface IFileNameOperations
    {
        string GetExtension(string fileName);
        string GetExtensionWithoutDot(string filePath);
        string ChangeExtension(string fileName, string extension);

        string GetDirectoryName(string filePath);
        string GetDirectoryPath(string filePath);
        string FullName(string fileName);

        string GetFileNameWithoutExtension(string fileName);
        string GetPathRoot(string filePath);

        string Combine(params string[] paths);
        string SetFileExtension(string fileName, string extension);

        void SetCurrentDirectory(string path);

        string GetFileName(string filePath);

        bool IsPathRooted(string fileName);
        bool IsValidFileName(string fileName);
    }
}