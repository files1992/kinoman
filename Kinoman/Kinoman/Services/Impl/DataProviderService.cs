using System.Collections.Generic;
using System.Threading.Tasks;
using Kinoman.Enums;

namespace Kinoman.Services.Impl
{
    public class DataProviderService : IDataProviderService
    {
        private readonly IDeserializer _deserializer;
        private readonly IDownloadService _downloadService;
        private Cities _city;

        public DataProviderService(IDownloadService downloadService, IDeserializer deserializer, Cities city)
        {
            _deserializer = deserializer;
            _downloadService = downloadService;
            _city = city;
        }
        public async Task<T> GetCurrentData<T>()
        {
            var city = _city.ToString();

            var stringData = _downloadService.DownloadData("d");
            var deserializedData = _deserializer.Deserialize<T>(await stringData);
            return deserializedData;
        }
    }

    public class MultiKinoUrlProviderService : IMultiKinoUrlProviderService
    {
        private IDownloadService _downloadService;
        private IDeserializer _deserializer;
        private Cities _city;

        public MultiKinoUrlProviderService(IDownloadService downloadService,IDeserializer deserializer, Cities city)
        {
            downloadService = _downloadService;
            deserializer = _deserializer;;
            city = _city;

        }
        public List<string> GetUrl(Cities city)
        {
            return null;
        }
    }
}