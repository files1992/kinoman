using Kinoman.Entities.MultiKino;
using Kinoman.Enums;
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
        private IUrlProviderService _urlProviderService;
        private DataProviderService _sut;


        [TestFixtureSetUp]
        public void TfSetUp()
        {
            _deserializerMock = Substitute.For<IDeserializer>();
            _downloadServiceMock = Substitute.For<IDownloadService>();
            _downloadServiceMock.DownloadData(Arg.Any<string>()).Returns("file content");
            _sut = new DataProviderService(_downloadServiceMock,_deserializerMock,Cities.Gdynia, _urlProviderService);
        }

        [Test]
        public async void CheckThatDownloadDataMethodIsCalledInDataProviderService()
        {
            var result = await _sut.GetCurrentData<MultiKinoShowing>();
            await _downloadServiceMock.Received().DownloadData(Arg.Any<string>());
        }

    }
}