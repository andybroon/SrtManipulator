using System;
using System.Collections.Generic;
using System.Globalization;
using DataDomain;

namespace Reader
{
    public class Reader : IReader
    {
        public IEnumerable<ISubtitleItem> ReadFile(string fileDirectory)
        {
            ITextFileReader fileReader = new TextFileReader(fileDirectory);
            while (!fileReader.EndOfStream)
            {
                int subtitleNumber;
                string nextLine = fileReader.ReadNextLine();
                bool startOfSubtitle = int.TryParse(nextLine, out subtitleNumber);
                if (startOfSubtitle)
                {
                    string timeLine = fileReader.ReadNextLine();
                    DateTime startTime = DateTime.ParseExact(timeLine.Substring(0, 12), "HH:mm:ss,fff", CultureInfo.InvariantCulture);
                    DateTime endTime = DateTime.ParseExact(timeLine.Substring(17), "HH:mm:ss,fff", CultureInfo.InvariantCulture);
                    string subtitleText = fileReader.ReadNextLine();
                    yield return new SubtitleItem(startTime, endTime, subtitleText);
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(nextLine))
                        throw new Exception("Unexpected line.");
                }
            }
        }
    }
}
