using Kinoman.Entities.MultiKino;
using Kinoman.Services;
using Kinoman.Services.Impl;
using NSubstitute;
using NUnit.Framework;

namespace Kinoman.UnitTests
{
    public class DataProviderServiceTests
    {
        private IDownloadService _downloadServiceMock;
        private IDeserializer _deserializerMock;
        private DataProviderService _sut;


        [TestFixtureSetUp]
        public void TfSetUp()
        {
            _deserializerMock = Substitute.For<IDeserializer>();
            _downloadServiceMock = Substitute.For<IDownloadService>();
            _downloadServiceMock.DownloadData(Arg.Any<string>()).Returns("file content");
            _sut = new DataProviderService(_downloadServiceMock,_deserializerMock);
        }

        [Test]
        public void CheckThatDownloadDataMethodIsCalled()
        {
            var result = _sut.GetCurrentData<MultiKinoShowing>();
            _downloadServiceMock.Received(1).DownloadData(Arg.Any<string>());
        }

    }
}