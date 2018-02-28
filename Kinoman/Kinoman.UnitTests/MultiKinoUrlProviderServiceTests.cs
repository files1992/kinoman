using Kinoman.Enums;
using Kinoman.Services;
using Kinoman.Services.Impl;
using NSubstitute;
using NUnit.Framework;

namespace Kinoman.UnitTests
{
    public class MultiKinoUrlProviderServiceTests
    {
        private IDownloadService _downloadServiceMock;
        private IDeserializer _deserializerMock;
        private MultiKinoUrlProviderService _sut;

        [TestFixtureSetUp]
        public void TfSetUp()
        {
            _deserializerMock = Substitute.For<IDeserializer>();
            _downloadServiceMock = Substitute.For<IDownloadService>();
            _downloadServiceMock.DownloadData(Arg.Any<string>()).Returns("file content");
            _sut = new MultiKinoUrlProviderService(_downloadServiceMock, _deserializerMock);
        }

        [Test]
        public void CheckThatDownloadDataMethodIsCalledInUrlProviderService()
        {
            var result = _sut.GetUrl(Cities.Gdynia);
            _downloadServiceMock.Received(1).DownloadData(Arg.Any<string>());
        }
    }
}