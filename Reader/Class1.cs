using System;
using System.Collections;
using System.Collections.Generic;
using DataDomain;

namespace Reader
{
    public class Class1
    {
    }

    public interface IReader
    {
        IEnumerable<ISubtitleItem> ReadFile(string fileDirectory);
    }
}
