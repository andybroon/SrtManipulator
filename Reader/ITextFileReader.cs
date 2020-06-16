using System.Collections.Generic;

namespace Reader
{
    public interface ITextFileReader
    {
        IEnumerable<string> ReadAllLines();

        string ReadNextLine();

        bool EndOfStream { get; }

        long Position { get; set; }
    }
}