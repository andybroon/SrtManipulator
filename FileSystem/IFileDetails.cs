using System;

namespace FileSystem
{
    public interface IFileDetails
    {
        long FileLength(string filePath);
        DateTime ModifiedTime(string filePath);
        DateTime ModifiedOrCreatedTime(string filePath);
        bool IsNetworkPath(string filePath);
        bool ContainsForbiddenCharacters(string filePath);
    }
}