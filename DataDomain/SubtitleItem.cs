using System;

namespace DataDomain
{
    public class SubtitleItem : ISubtitleItem
    {
        public SubtitleItem(DateTime startTime, DateTime endTime, string text)
        {
            StartTime = startTime;
            EndTime = endTime;
            Text = text;
        }

        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public string Text { get; }
    }
}
