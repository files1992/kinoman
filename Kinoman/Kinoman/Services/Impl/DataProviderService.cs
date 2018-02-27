using System.Threading.Tasks;

namespace Kinoman.Services.Impl
{
    public class DataProviderService : IDataProviderService
    {
        private readonly IDeserializer _deserializer;
        private readonly IDownloadService _downloadService;

        public DataProviderService(IDownloadService downloadService, IDeserializer deserializer)
        {
            _deserializer = deserializer;
            _downloadService = downloadService;
        }
        public async Task<T> GetCurrentData<T>()
        {
            var stringData = _downloadService.DownloadData("d");
            var deserializedData = _deserializer.Deserialize<T>(await stringData);
            return deserializedData;
        }
    }
}