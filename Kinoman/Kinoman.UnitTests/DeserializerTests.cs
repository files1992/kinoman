using NUnit.Framework;

namespace Kinoman.UnitTests
{
    public class DeserializerTests
    {
        public GetTestData GetTestData { get; set; }
        public Deserializer Sut { get; set; }

        [TestFixtureSetUp]
        public void TfSetUp()
        {
            Sut = new Deserializer();
            GetTestData = new GetTestData();
        }

        [Test]
        public void 
    }
}