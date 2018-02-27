using System.Threading.Tasks;
using Kinoman.Entities.MultiKino;
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
}