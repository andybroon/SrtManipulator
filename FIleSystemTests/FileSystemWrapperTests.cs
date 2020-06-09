using FileSystem;
using NUnit.Framework;

namespace FileSystemTests
{
    public class FileSystemWrapperTests
    {
        private IFileSystemWrapper _fileSystemWrapper;

        [SetUp]
        public void Setup()
        {
            _fileSystemWrapper = new FileSystemWrapper();
        }

        [TestCase("mydata.dat", ".dat")]
        [TestCase(@"C:\myfile", "")]
        [TestCase("", "")]
        public void ExtensionTests(string fileName, string expected)
        {
            string actual = _fileSystemWrapper.GetExtension(fileName);
            Assert.AreEqual(expected, actual);
        }
    }
}