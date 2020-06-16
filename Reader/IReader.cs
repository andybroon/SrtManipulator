using System.Collections.Generic;
using DataDomain;

namespace Reader
{
    public interface IReader
    {
        IEnumerable<ISubtitleItem> ReadFile(string fileDirectory);
    }
}