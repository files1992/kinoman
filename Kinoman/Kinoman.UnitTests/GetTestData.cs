using System.Collections.Generic;
using Kinoman.UnitTests.Enums;

namespace Kinoman.UnitTests
{
    public class GetTestData
    {
        public Dictionary<FileType,string> Path { get; } = new Dictionary<FileType, string>()
        {
            {FileType.MultiKino,"TestData/MultiKino.json"}
        };

        public string GetSampleResponse()
        {
            return null;
        }
    }
}