using System;

namespace DataDomain
{
    public interface ISubtitleItem
    {
        DateTime StartTime { get; }
        DateTime EndTime { get; }
        string Text { get; }
    }
}