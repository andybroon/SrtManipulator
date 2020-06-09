using System;
using System.Collections.Generic;
using System.IO;

namespace FileSystem
{
    public class FileSystemWrapper : IFileSystemWrapper
    {
        private static char[] _invalidFileNameChars = Path.GetInvalidFileNameChars();

        public bool Exists(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                return false;
            return File.Exists(path) || Directory.Exists(path);
        }

        public bool FileExists(string filePath)
        {
            return !string.IsNullOrWhiteSpace(filePath) && File.Exists(filePath);
        }

        public bool DirectoryExists(string directoryPath)
        {
            return !string.IsNullOrWhiteSpace(directoryPath) && Directory.Exists(directoryPath);
        }

        public string GetExtension(string fileName)
        {
            return Path.GetExtension(fileName);
        }

        public string GetExtensionWithoutDot(string filePath)
        {
            string extension = GetExtension(filePath);
            return !string.IsNullOrEmpty(extension) ? extension.Substring(1, extension.Length - 1) : extension;
        }

        public string ChangeExtension(string fileName, string extension)
        {
            return Path.ChangeExtension(fileName, extension);
        }

        public string GetDirectoryName(string filePath)
        {
            throw new NotImplementedException();
        }

        public string GetDirectoryPath(string filePath)
        {
            throw new NotImplementedException();
        }

        public string FullName(string fileName)
        {
            throw new NotImplementedException();
        }

        public string GetFileNameWithoutExtension(string fileName)
        {
            throw new NotImplementedException();
        }

        public string GetPathRoot(string filePath)
        {
            throw new NotImplementedException();
        }

        public string Combine(params string[] paths)
        {
            throw new NotImplementedException();
        }

        public string SetFileExtension(string fileName, string extension)
        {
            throw new NotImplementedException();
        }

        public void SetCurrentDirectory(string path)
        {
            throw new NotImplementedException();
        }

        public string GetFileName(string filePath)
        {
            throw new NotImplementedException();
        }

        public bool IsPathRooted(string fileName)
        {
            throw new NotImplementedException();
        }

        public bool IsValidFileName(string fileName)
        {
            throw new NotImplementedException();
        }

        public long FileLength(string filePath)
        {
            throw new NotImplementedException();
        }

        public DateTime ModifiedTime(string filePath)
        {
            throw new NotImplementedException();
        }

        public DateTime ModifiedOrCreatedTime(string filePath)
        {
            throw new NotImplementedException();
        }

        public bool IsNetworkPath(string filePath)
        {
            throw new NotImplementedException();
        }

        public bool ContainsForbiddenCharacters(string filePath)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAllFileNamesInDirectory(string directoryName, string filter = "")
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAllFilePathsInDirectory(string directoryName, string filter = "")
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAllFilePathsInDirectory(string directoryName, IEnumerable<string> filters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAllFileNamesNextToFile(string fileName, string filter = "")
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAllSubDirectories(string directoryName)
        {
            throw new NotImplementedException();
        }

        public string GetFileInDirectory(string directoryName, string filter = "")
        {
            throw new NotImplementedException();
        }

        public string GetFileInDirectoryWithPath(string directoryName, string filter = "")
        {
            throw new NotImplementedException();
        }

        public void Copy(string source, string target, bool overwrite = false)
        {
            throw new NotImplementedException();
        }

        public void CopyDirectoryContents(string source, string target, bool overwrite = false)
        {
            throw new NotImplementedException();
        }

        public void CreateDirectory(string directory)
        {
            throw new NotImplementedException();
        }

        public void CreateFile(string filePath)
        {
            throw new NotImplementedException();
        }

        public void DeleteDirectory(string directory)
        {
            throw new NotImplementedException();
        }

        public void DeleteFile(string fileName)
        {
            throw new NotImplementedException();
        }

        public bool IsFileInUse(string filePath)
        {
            throw new NotImplementedException();
        }

        public void RefreshDirectory(string path)
        {
            throw new NotImplementedException();
        }

        public void RefreshFile(string fileName)
        {
            throw new NotImplementedException();
        }

        public string GetTempPath()
        {
            throw new NotImplementedException();
        }

        public char DirectorySeparatorChar { get; }
        public string TempPath { get; }
    }
}
