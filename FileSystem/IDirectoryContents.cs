using System.Collections.Generic;

namespace FileSystem
{
    public interface IDirectoryContents
    {
        IEnumerable<string> GetAllFileNamesInDirectory(string directoryName, string filter = "");

        IEnumerable<string> GetAllFilePathsInDirectory(string directoryName, string filter = "");

        IEnumerable<string> GetAllFilePathsInDirectory(string directoryName, IEnumerable<string> filters);

        IEnumerable<string> GetAllFileNamesNextToFile(string fileName, string filter = "");

        IEnumerable<string> GetAllSubDirectories(string directoryName);

        string GetFileInDirectory(string directoryName, string filter = "");

        string GetFileInDirectoryWithPath(string directoryName, string filter = "");
    }
}