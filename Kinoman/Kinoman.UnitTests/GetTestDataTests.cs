using System.IO;
using NUnit.Framework;

namespace Kinoman.UnitTests
{
    public class GetTestDataTests
    {
        public GetTestData Sut { get; set; }
        [TestFixtureSetUp]
        public void TfSetUp()
        {
            Sut = new GetTestData();
        }

        
        [Test]
        public void ReadFileTest()
        {
            var contents = Sut.GetSampleResponse();

            Assert.That(contents, Is.Not.Null);
        }

        [Test]
        public void FileIsExist()
        {
            foreach (var path in Sut.Path.Values)
            {
                var fileIsThere = File.Exists(path);
                Assert.That(fileIsThere, $"File missing: {path}");
            }
        }
    }
}