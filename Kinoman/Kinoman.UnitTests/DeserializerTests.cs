using Kinoman.Entities.MultiKino;
using Kinoman.Services.Impl;
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
        public void MultiKinoSampleDeserializerTests()
        {
            var expected = "15:17 do Paryza";
            var jsonString = GetTestData.GetSampleResponse();
            var deserializedObject = Sut.Deserialize<MultiKinoShowing>(jsonString);
            var serviceFilmPageNameoutput = deserializedObject.Films[0].Title;

            Assert.That(expected,Is.EqualTo(serviceFilmPageNameoutput));
        }
    }
}