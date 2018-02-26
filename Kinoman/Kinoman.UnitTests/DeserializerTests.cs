using Kinoman.UnitTests.Enums;
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
        public void SampleDeserializerTests()
        {
            var expected = "15-17-do-paryza";
            var jsonString = GetTestData.GetSampleResponse(FileType.MultiKino);
            var deserializedObject = Sut.Deserialize(jsonString);
            
            Assert.That(expected,Is.EqualTo(deserializedObject.Films[0].FilmPageName));
        }
    }
}