using System.Collections.Generic;
using System.IO;
using FileSystem;

namespace Reader
{
    public class TextFileReader : ITextFileReader
    {
        private readonly StreamReader _reader;
        private readonly FileStream _stream;

        public TextFileReader(string filePath)
        {
            IExists exists = new FileSystemWrapper();
            if (!exists.FileExists(filePath)) 
                return;
            _stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            _reader = new StreamReader(new BufferedStream(_stream));
        }

        public IEnumerable<string> ReadAllLines()
        {
            if (_reader == null) 
                yield break;
            string line;
            while ((line = _reader.ReadLine()) != null)
                yield return line;
        }

        public string ReadNextLine()
        {
            return _reader.ReadLine();
        }

        public bool EndOfStream => _reader.EndOfStream;
        public long Position
        {
            get => _stream.Position;
            set => _stream.Position = value;
        }
    }
}